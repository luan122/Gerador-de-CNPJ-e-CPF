using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Globalization;

namespace Gerador_de_CNPJ
{
    public partial class CPF_CNPJ_Generator : Form
    {
        Int64 soma1, soma2, i, erro, cnpj, cpf, parte1, parte2, parte3, dig1, parte5, parte6, parte7, dig2;
        Int64[] numero = new Int64[13];

        private void label5_Click(object sender, EventArgs e)
        {
            Sobre sobre = new Sobre();
            sobre.Show();
        }

        Random rand = new Random();
        private bool nonNumberEntered;

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

        private void cmbLinguas_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.Lingua != Convert.ToString(cmbLinguas.SelectedValue))
            {
                //Salva lingua selecionada nas configurações do programa
                Properties.Settings.Default.Lingua = Convert.ToString(cmbLinguas.SelectedValue);
                //Seta a lingua do programa para a lingua salva nas configurações do programa
                Thread.CurrentThread.CurrentUICulture = new CultureInfo(Properties.Settings.Default.Lingua);
                //Salva as modificações nas configurações do programa
                Properties.Settings.Default.Save();
                //Aguarda alguns milisegundos antes de reiniciar o programa para traduzir na lingua selecionada
                Thread.Sleep(50);
                Application.Restart();
            }
        }

        private void CPF_CNPJ_Generator_Load(object sender, EventArgs e)
        {
            Dictionary<string, string> comboSource = new Dictionary<string, string>();
            if (Thread.CurrentThread.CurrentUICulture.Name == "pt-BR")
            {
                comboSource.Add("pt-BR", "Português");
                comboSource.Add("en", "Inglês");
            }
            if (Thread.CurrentThread.CurrentUICulture.Name == "en")
            {
                comboSource.Add("pt-BR", "Portuguese");
                comboSource.Add("en", "English");
            }
            cmbLinguas.DataSource = new BindingSource(comboSource, null);
            cmbLinguas.DisplayMember = "Value";
            cmbLinguas.ValueMember = "Key";
            cmbLinguas.SelectedValue = Properties.Settings.Default.Lingua;
        }

        public CPF_CNPJ_Generator()
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(Properties.Settings.Default.Lingua);
            InitializeComponent();
        }

        private void btnCriar_Click(object sender, EventArgs e)
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CPF_CNPJ_Generator));
            if (cmbTipo.Text == "CNPJ")
            {
                if (cmbModelo.Text == Resources.Strings.Mask1)
                {
                    Task.Factory.StartNew(() => CnpjSemMascara(Convert.ToInt32(txtQuantidade.Text)));
                    return;
                }
                else if(cmbModelo.Text == Resources.Strings.Mask2)
                {
                    CnpjComMascara(Convert.ToInt32(txtQuantidade.Text));
                    return;
                }
                else
                {
                    MessageBox.Show(Resources.Strings.Warning2);
                    return;
                }
            }
            else if (cmbTipo.Text == "CPF")
            {
                if (cmbModelo.Text == Resources.Strings.Mask1)
                {
                    CpfSemMascara(Convert.ToInt32(txtQuantidade.Text));
                    return;
                }
                else if (cmbModelo.Text == Resources.Strings.Mask2)
                {
                    CpfComMascara(Convert.ToInt32(txtQuantidade.Text));
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

        private void CpfComMascara(Int64 quant)
        {
            Invoke(new Action(() => btnCriar.Enabled = false));
            Invoke(new Action(() => btnLimpar.Enabled = false));
            Invoke(new Action(() => rtbResultado.Enabled = false));
            for (cpf = 1; cpf <= quant; cpf++)
            {
                for (i = 1; i <= 9; i++)
                {
                    erro = 1;
                    do
                    {
                        if (erro > 1)
                        {
                            MessageBox.Show("Numero invalido.\n");
                            erro = 1;
                        }
                        numero[i] = (rand.Next()) % 9;
                        erro++;
                    } while (numero[i] > 9 || numero[i] < 0);
                }
                //*==========================================*
                //|       Primeiro digito veridicador        |
                //*==========================================*
                soma1 = ((numero[1] * 10) +
                      (numero[2] * 9) +
                      (numero[3] * 8) +
                      (numero[4] * 7) +
                      (numero[5] * 6) +
                      (numero[6] * 5) +
                      (numero[7] * 4) +
                      (numero[8] * 3) +
                      (numero[9] * 2));
                parte1 = (soma1 / 11);
                parte2 = (parte1 * 11);
                parte3 = (soma1 - parte2);
                dig1 = (11 - parte3);
                if (dig1 > 9) dig1 = 0;
                //*==========================================*
                //|        Segundo digito veridicador        |
                //*==========================================*
                soma2 = ((numero[1] * 11) +
                      (numero[2] * 10) +
                      (numero[3] * 9) +
                      (numero[4] * 8) +
                      (numero[5] * 7) +
                      (numero[6] * 6) +
                      (numero[7] * 5) +
                      (numero[8] * 4) +
                      (numero[9] * 3) +
                      (dig1 * 2));
                parte5 = (soma2 / 11);
                parte6 = (parte5 * 11);
                parte7 = (soma2 - parte6);
                dig2 = (11 - parte7);
                if (dig2 > 9) dig2 = 0;
                //*==========================================*
                //|       Impressao do numero completo       | 
                //*==========================================*
                for (i = 1; i <= 9; i++)
                {
                    Invoke(new Action(() => rtbResultado.Text += Convert.ToString(numero[i])));
                    if (i - 1 == 2) Invoke(new Action(() => rtbResultado.Text += "."));
                    if (i - 1 == 5) Invoke(new Action(() => rtbResultado.Text += "."));
                }
                Invoke(new Action(() => rtbResultado.Text += "-" + dig1 + dig2 + "\n")); // dois últimos digitos
            }
            Invoke(new Action(() => rtbResultado.Enabled = true));
            Invoke(new Action(() => btnCriar.Enabled = true));
            Invoke(new Action(() => btnLimpar.Enabled = true));
            MessageBox.Show(Resources.Strings.Finished);
        }

        private void CpfSemMascara(Int64 quant)
        {
            Invoke(new Action(() => btnCriar.Enabled = false));
            Invoke(new Action(() => btnLimpar.Enabled = false));
            Invoke(new Action(() => rtbResultado.Enabled = false));
            for (cpf = 1; cpf <= quant; cpf++)
            {
                for (i = 1; i <= 9; i++)
                {
                    erro = 1;
                    do
                    {
                        if (erro > 1)
                        {
                            MessageBox.Show("Numero invalido.\n");
                            erro = 1;
                        }
                        numero[i] = (rand.Next()) % 9;
                        erro++;
                    } while (numero[i] > 9 || numero[i] < 0);
                }
                //*==========================================*
                //|       Primeiro digito veridicador        |
                //*==========================================*
                soma1 = ((numero[1] * 10) +
                      (numero[2] * 9) +
                      (numero[3] * 8) +
                      (numero[4] * 7) +
                      (numero[5] * 6) +
                      (numero[6] * 5) +
                      (numero[7] * 4) +
                      (numero[8] * 3) +
                      (numero[9] * 2));
                parte1 = (soma1 / 11);
                parte2 = (parte1 * 11);
                parte3 = (soma1 - parte2);
                dig1 = (11 - parte3);
                if (dig1 > 9) dig1 = 0;
                //*==========================================*
                //|        Segundo digito veridicador        |
                //*==========================================*
                soma2 = ((numero[1] * 11) +
                      (numero[2] * 10) +
                      (numero[3] * 9) +
                      (numero[4] * 8) +
                      (numero[5] * 7) +
                      (numero[6] * 6) +
                      (numero[7] * 5) +
                      (numero[8] * 4) +
                      (numero[9] * 3) +
                      (dig1 * 2));
                parte5 = (soma2 / 11);
                parte6 = (parte5 * 11);
                parte7 = (soma2 - parte6);
                dig2 = (11 - parte7);
                if (dig2 > 9) dig2 = 0;
                //*==========================================*
                //|       Impressao do numero completo       | 
                //*==========================================*
                for (i = 1; i <= 9; i++)
                {
                    //numeros do CPF
                    Invoke(new Action(() => rtbResultado.Text += Convert.ToString(numero[i])));
                }
                // dois últimos digitos
                Invoke(new Action(() => rtbResultado.Text += dig1 + "" + dig2 + "\n"));
            }
            Invoke(new Action(() => rtbResultado.Enabled = true));
            Invoke(new Action(() => btnCriar.Enabled = true));
            Invoke(new Action(() => btnLimpar.Enabled = true));
            MessageBox.Show(Resources.Strings.Finished);
        }

        private void CnpjComMascara(Int64 quant)
        {
            Invoke(new Action(() => btnCriar.Enabled = false));
            Invoke(new Action(() => btnLimpar.Enabled = false));
            Invoke(new Action(() => rtbResultado.Enabled = false));
            for (cnpj = 1; cnpj <= quant; cnpj++)
            {
                for (i = 1; i <= 8; i++)
                {
                    numero[i] = (rand.Next()) % 9;
                }
                numero[9] = 0;
                numero[10] = 0;
                numero[11] = 0;
                numero[12] = (rand.Next()) % 9;
                //*==========================================*
                //|       Primeiro digito veridicador        |
                //*==========================================*
                soma1 = ((numero[1] * 5) +
                      (numero[2] * 4) +
                      (numero[3] * 3) +
                      (numero[4] * 2) +
                      (numero[5] * 9) +
                      (numero[6] * 8) +
                      (numero[7] * 7) +
                      (numero[8] * 6) +
                      (numero[9] * 5) +
                      (numero[10] * 4) +
                      (numero[11] * 3) +
                      (numero[12] * 2));
                parte1 = (soma1 / 11);
                parte2 = (parte1 * 11);
                parte3 = (soma1 - parte2);
                dig1 = (11 - parte3);
                if (dig1 > 9) dig1 = 0;
                //*==========================================*
                //|        Segundo digito veridicador        |
                //*==========================================*
                soma2 = ((numero[1] * 6) +
                      (numero[2] * 5) +
                      (numero[3] * 4) +
                      (numero[4] * 3) +
                      (numero[5] * 2) +
                      (numero[6] * 9) +
                      (numero[7] * 8) +
                      (numero[8] * 7) +
                      (numero[9] * 6) +
                      (numero[10] * 5) +
                      (numero[11] * 4) +
                      (numero[12] * 3) +
                      (dig1 * 2));
                parte5 = (soma2 / 11);
                parte6 = (parte5 * 11);
                parte7 = (soma2 - parte6);
                dig2 = (11 - parte7);
                if (dig2 > 9) dig2 = 0;
                //*==========================================*
                //|       Impressao do numero completo       | 
                //*==========================================*
                //ostrm.SetLength(0);
                for (i = 1; i <= 12; i++)
                {
                    //numeros do CNPJ
                    Invoke(new Action(() => rtbResultado.Text += Convert.ToString(numero[i])));
                    if (i == 2) Invoke(new Action(() => rtbResultado.Text += "."));//imprime um ponto depois da 2ª casa
                    if (i == 5) Invoke(new Action(() => rtbResultado.Text += "."));//imprime um ponto depois da 5ª casa
                    if (i == 8) Invoke(new Action(() => rtbResultado.Text += "/"));//imprime uma barra depois da 8ª casa
                }
                Invoke(new Action(() => rtbResultado.Text += "-"+dig1 +""+ dig2 + "\n")); // dois últimos digitos
            }
            Invoke(new Action(() => rtbResultado.Enabled = true));
            Invoke(new Action(() => btnCriar.Enabled = true));
            Invoke(new Action(() => btnLimpar.Enabled = true));
            MessageBox.Show(Resources.Strings.Finished);
        }

        private void CnpjSemMascara(Int64 quant)
        {
            Invoke(new Action(() => btnCriar.Enabled = false));
            Invoke(new Action(() => btnLimpar.Enabled = false));
            Invoke(new Action(() => rtbResultado.Enabled = false));
            for (cnpj = 1; cnpj <= quant; cnpj++)
            {
                for (i = 1; i <= 8; i++)
                {
                    numero[i] = (rand.Next()) % 9;
                }
                numero[9] = 0;
                numero[10] = 0;
                numero[11] = 0;
                numero[12] = (rand.Next()) % 9;
                //*==========================================*
                //|       Primeiro digito veridicador        |
                //*==========================================*
                soma1 = ((numero[1] * 5) +
                      (numero[2] * 4) +
                      (numero[3] * 3) +
                      (numero[4] * 2) +
                      (numero[5] * 9) +
                      (numero[6] * 8) +
                      (numero[7] * 7) +
                      (numero[8] * 6) +
                      (numero[9] * 5) +
                      (numero[10] * 4) +
                      (numero[11] * 3) +
                      (numero[12] * 2));
                parte1 = (soma1 / 11);
                parte2 = (parte1 * 11);
                parte3 = (soma1 - parte2);
                dig1 = (11 - parte3);
                if (dig1 > 9) dig1 = 0;
                //*==========================================*
                //|        Segundo digito veridicador        |
                //*==========================================*
                soma2 = ((numero[1] * 6) +
                      (numero[2] * 5) +
                      (numero[3] * 4) +
                      (numero[4] * 3) +
                      (numero[5] * 2) +
                      (numero[6] * 9) +
                      (numero[7] * 8) +
                      (numero[8] * 7) +
                      (numero[9] * 6) +
                      (numero[10] * 5) +
                      (numero[11] * 4) +
                      (numero[12] * 3) +
                      (dig1 * 2));
                parte5 = (soma2 / 11);
                parte6 = (parte5 * 11);
                parte7 = (soma2 - parte6);
                dig2 = (11 - parte7);
                if (dig2 > 9) dig2 = 0;
                //*==========================================*
                //|       Impressao do numero completo       | 
                //*==========================================*
                //ostrm.SetLength(0);
                for (i = 1; i <= 12; i++)
                {
                    //numeros do CNPJ
                    Invoke(new Action(() => rtbResultado.Text += Convert.ToString(numero[i])));
                }
                // dois últimos digitos
                Invoke(new Action(() => rtbResultado.Text += dig1 + "" + dig2 + "\n"));
            }
            Invoke(new Action(() => rtbResultado.Enabled = true));
            Invoke(new Action(() => btnCriar.Enabled = true));
            Invoke(new Action(() => btnLimpar.Enabled = true));
            MessageBox.Show(Resources.Strings.Finished);
        }
    }
}
