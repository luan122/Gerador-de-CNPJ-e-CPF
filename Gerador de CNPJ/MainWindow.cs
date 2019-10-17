using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;

namespace Gerador_de_CNPJ
{
    public partial class CPF_CNPJ_Generator : MetroFramework.Forms.MetroForm
    {
        private bool nonNumberEntered;
        private NumberGenerator generator = new NumberGenerator();

        private void label5_Click(object sender, EventArgs e)
        {
            Sobre sobre = new Sobre();
            sobre.Show();
        }

        private void btLanguagePT_Click(object sender, EventArgs e) {
            changeLanguage(sender);
        }

        private void changeLanguage(object sender) {
            if (Properties.Settings.Default.Language != Convert.ToString(((Button)sender).Text))
            {
                //Salva lingua selecionada nas configurações do programa
                Properties.Settings.Default.Language = Convert.ToString(((Button)sender).Text);
                //Seta a lingua do programa para a lingua salva nas configurações do programa
                Thread.CurrentThread.CurrentUICulture = new CultureInfo(Properties.Settings.Default.Language);
                //Salva as modificações nas configurações do programa
                Properties.Settings.Default.Save();
                //Aguarda alguns milisegundos antes de reiniciar o programa para traduzir na lingua selecionada
                Thread.Sleep(50);
                Application.Restart();
            }
        }

        private void btLanguageEN_Click(object sender, EventArgs e)
        {
            changeLanguage(sender);
        }


        private void txtQuantidade_KeyDown(object sender, KeyEventArgs e)
        {
            // Initialize the flag to false.
            nonNumberEntered = false;

            // Determine whether the keystroke is a number from the top of the keyboard.
            if (e.KeyCode < Keys.D0 || e.KeyCode > Keys.D9)
            {
                // Determine whether the keystroke is a number from the keypad.
                if (e.KeyCode < Keys.NumPad0 || e.KeyCode > Keys.NumPad9)
                {
                    // Determine whether the keystroke is a backspace.
                    if (e.KeyCode != Keys.Back)
                    {
                        // A non-numerical keystroke was pressed.
                        // Set the flag to true and evaluate in KeyPress event.
                        nonNumberEntered = true;
                    }
                }
            }
            //If shift key was pressed, it's not a number.
            if (Control.ModifierKeys == Keys.Shift)
            {
                nonNumberEntered = true;
            }
        }

        private void txtQuantidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (nonNumberEntered == true)
            {
                MessageBox.Show(Resources.Strings.Warning3, "Caractere invalido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            rtbResultado.Clear();
        }

        private void CPF_CNPJ_Generator_Load(object sender, EventArgs e) {
            rbTypeCNPJ.Checked = true;
            txQuantidade.Text = 1.ToString();
            txQuantidade.Focus();
            metroProgressSpinner1.Visible = false;
        }

        public CPF_CNPJ_Generator()
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(Properties.Settings.Default.Language);
            InitializeComponent();
        }

        public void UpdateUI(string content) {
            rtbResultado.Text = content;
            rtbResultado.Enabled = true;
            btGenerate.Enabled = true;
            metroProgressSpinner1.Visible = false;
        }
        public async void AsyncOperation(Func<string> func)
        {
            try
            {
                rtbResultado.Clear();
                rtbResultado.Enabled = false;
                btGenerate.Enabled = false;
                metroProgressSpinner1.Visible = true;
                string t = await Task.Run(func);
                UpdateUI(t);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btGenerate_Click(object sender, EventArgs e)
        {
            if (rbTypeCNPJ.Checked)
            {
                if (!tgMask.Checked)
                {
                    AsyncOperation(() => generator.CnpjSemMascara(Convert.ToInt32(txQuantidade.Text)));
                    return;
                }
                else if (tgMask.Checked)
                {
                    AsyncOperation(() => generator.CnpjComMascara(Convert.ToInt32(txQuantidade.Text)));
                    return;
                }
                else
                {
                    MessageBox.Show(Resources.Strings.Warning2);
                    return;
                }
            }
            else if (rbTypeCPF.Checked)
            {
                if (!tgMask.Checked)
                {
                    AsyncOperation(() => generator.CpfSemMascara(Convert.ToInt32(txQuantidade.Text)));
                    return;
                }
                else if (tgMask.Checked)
                {
                    AsyncOperation(() => generator.CpfComMascara(Convert.ToInt32(txQuantidade.Text)));
                    return;
                }
                else
                {
                    MessageBox.Show(Resources.Strings.Warning2);
                    return;
                }
            }
            else
            {
                MessageBox.Show(Resources.Strings.Warning1);
                return;
            }
        }

        private Action<Task<string>> OnWorkCompleted(string result)
        {
            rtbResultado.Text = result;
            return null;
        }

        private void btClipboard_Click(object sender, EventArgs e)
        {
            if (rtbResultado.Enabled)
                Clipboard.SetText(rtbResultado.Text);
        }

        private void txQuantidade_Click(object sender, EventArgs e)
        {
            var x = Convert.ToInt64(txQuantidade.Text);
            x++;
            txQuantidade.Text = x.ToString();
        }

    }
}
