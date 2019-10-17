namespace Gerador_de_CNPJ
{
    partial class CPF_CNPJ_Generator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CPF_CNPJ_Generator));
            this.rtbResultado = new MetroFramework.Controls.MetroTextBox();
            this.label5 = new MetroFramework.Controls.MetroLabel();
            this.pnMain = new MetroFramework.Controls.MetroPanel();
            this.btGenerate = new MetroFramework.Controls.MetroButton();
            this.metroPanel4 = new MetroFramework.Controls.MetroPanel();
            this.tgMask = new MetroFramework.Controls.MetroToggle();
            this.lbMask = new MetroFramework.Controls.MetroLabel();
            this.metroPanel3 = new MetroFramework.Controls.MetroPanel();
            this.txQuantidade = new MetroFramework.Controls.MetroTextBox();
            this.lbQuantity = new MetroFramework.Controls.MetroLabel();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.lbType = new MetroFramework.Controls.MetroLabel();
            this.rbTypeCPF = new MetroFramework.Controls.MetroRadioButton();
            this.rbTypeCNPJ = new MetroFramework.Controls.MetroRadioButton();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.pnLanguage = new MetroFramework.Controls.MetroPanel();
            this.btLanguageEN = new MetroFramework.Controls.MetroButton();
            this.btLanguagePT = new MetroFramework.Controls.MetroButton();
            this.btClipboard = new MetroFramework.Controls.MetroButton();
            this.metroProgressSpinner1 = new MetroFramework.Controls.MetroProgressSpinner();
            this.pnMain.SuspendLayout();
            this.metroPanel4.SuspendLayout();
            this.metroPanel3.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            this.metroPanel2.SuspendLayout();
            this.pnLanguage.SuspendLayout();
            this.SuspendLayout();
            // 
            // rtbResultado
            // 
            resources.ApplyResources(this.rtbResultado, "rtbResultado");
            // 
            // 
            // 
            this.rtbResultado.CustomButton.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.rtbResultado.CustomButton.Location = ((System.Drawing.Point)(resources.GetObject("resource.Location")));
            this.rtbResultado.CustomButton.Name = "";
            this.rtbResultado.CustomButton.Size = ((System.Drawing.Size)(resources.GetObject("resource.Size")));
            this.rtbResultado.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.rtbResultado.CustomButton.TabIndex = ((int)(resources.GetObject("resource.TabIndex")));
            this.rtbResultado.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.rtbResultado.CustomButton.UseSelectable = true;
            this.rtbResultado.CustomButton.Visible = ((bool)(resources.GetObject("resource.Visible")));
            this.rtbResultado.Lines = new string[0];
            this.rtbResultado.MaxLength = 32767;
            this.rtbResultado.Multiline = true;
            this.rtbResultado.Name = "rtbResultado";
            this.rtbResultado.PasswordChar = '\0';
            this.rtbResultado.ReadOnly = true;
            this.rtbResultado.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.rtbResultado.SelectedText = "";
            this.rtbResultado.SelectionLength = 0;
            this.rtbResultado.SelectionStart = 0;
            this.rtbResultado.ShortcutsEnabled = true;
            this.rtbResultado.UseSelectable = true;
            this.rtbResultado.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.rtbResultado.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // pnMain
            // 
            this.pnMain.Controls.Add(this.metroProgressSpinner1);
            this.pnMain.Controls.Add(this.btGenerate);
            this.pnMain.Controls.Add(this.metroPanel4);
            this.pnMain.Controls.Add(this.metroPanel3);
            this.pnMain.Controls.Add(this.metroPanel1);
            resources.ApplyResources(this.pnMain, "pnMain");
            this.pnMain.HorizontalScrollbarBarColor = true;
            this.pnMain.HorizontalScrollbarHighlightOnWheel = false;
            this.pnMain.HorizontalScrollbarSize = 10;
            this.pnMain.Name = "pnMain";
            this.pnMain.VerticalScrollbarBarColor = true;
            this.pnMain.VerticalScrollbarHighlightOnWheel = false;
            this.pnMain.VerticalScrollbarSize = 10;
            // 
            // btGenerate
            // 
            resources.ApplyResources(this.btGenerate, "btGenerate");
            this.btGenerate.Name = "btGenerate";
            this.btGenerate.UseSelectable = true;
            this.btGenerate.Click += new System.EventHandler(this.btGenerate_Click);
            // 
            // metroPanel4
            // 
            this.metroPanel4.Controls.Add(this.tgMask);
            this.metroPanel4.Controls.Add(this.lbMask);
            this.metroPanel4.HorizontalScrollbarBarColor = true;
            this.metroPanel4.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel4.HorizontalScrollbarSize = 10;
            resources.ApplyResources(this.metroPanel4, "metroPanel4");
            this.metroPanel4.Name = "metroPanel4";
            this.metroPanel4.VerticalScrollbarBarColor = true;
            this.metroPanel4.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel4.VerticalScrollbarSize = 10;
            // 
            // tgMask
            // 
            resources.ApplyResources(this.tgMask, "tgMask");
            this.tgMask.Name = "tgMask";
            this.tgMask.UseSelectable = true;
            // 
            // lbMask
            // 
            resources.ApplyResources(this.lbMask, "lbMask");
            this.lbMask.Name = "lbMask";
            // 
            // metroPanel3
            // 
            this.metroPanel3.Controls.Add(this.txQuantidade);
            this.metroPanel3.Controls.Add(this.lbQuantity);
            this.metroPanel3.HorizontalScrollbarBarColor = true;
            this.metroPanel3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel3.HorizontalScrollbarSize = 10;
            resources.ApplyResources(this.metroPanel3, "metroPanel3");
            this.metroPanel3.Name = "metroPanel3";
            this.metroPanel3.VerticalScrollbarBarColor = true;
            this.metroPanel3.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel3.VerticalScrollbarSize = 10;
            // 
            // txQuantidade
            // 
            // 
            // 
            // 
            this.txQuantidade.CustomButton.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            this.txQuantidade.CustomButton.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("resource.ImeMode")));
            this.txQuantidade.CustomButton.Location = ((System.Drawing.Point)(resources.GetObject("resource.Location1")));
            this.txQuantidade.CustomButton.Name = "";
            this.txQuantidade.CustomButton.Size = ((System.Drawing.Size)(resources.GetObject("resource.Size1")));
            this.txQuantidade.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txQuantidade.CustomButton.TabIndex = ((int)(resources.GetObject("resource.TabIndex1")));
            this.txQuantidade.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txQuantidade.CustomButton.UseSelectable = true;
            this.txQuantidade.CustomButton.Visible = ((bool)(resources.GetObject("resource.Visible1")));
            resources.ApplyResources(this.txQuantidade, "txQuantidade");
            this.txQuantidade.Lines = new string[0];
            this.txQuantidade.MaxLength = 32767;
            this.txQuantidade.Name = "txQuantidade";
            this.txQuantidade.PasswordChar = '\0';
            this.txQuantidade.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txQuantidade.SelectedText = "";
            this.txQuantidade.SelectionLength = 0;
            this.txQuantidade.SelectionStart = 0;
            this.txQuantidade.ShortcutsEnabled = true;
            this.txQuantidade.UseSelectable = true;
            this.txQuantidade.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txQuantidade.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txQuantidade.ButtonClick += new MetroFramework.Controls.MetroTextBox.ButClick(this.txQuantidade_Click);
            // 
            // lbQuantity
            // 
            resources.ApplyResources(this.lbQuantity, "lbQuantity");
            this.lbQuantity.Name = "lbQuantity";
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.lbType);
            this.metroPanel1.Controls.Add(this.rbTypeCPF);
            this.metroPanel1.Controls.Add(this.rbTypeCNPJ);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            resources.ApplyResources(this.metroPanel1, "metroPanel1");
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // lbType
            // 
            resources.ApplyResources(this.lbType, "lbType");
            this.lbType.Name = "lbType";
            // 
            // rbTypeCPF
            // 
            resources.ApplyResources(this.rbTypeCPF, "rbTypeCPF");
            this.rbTypeCPF.Name = "rbTypeCPF";
            this.rbTypeCPF.UseSelectable = true;
            // 
            // rbTypeCNPJ
            // 
            resources.ApplyResources(this.rbTypeCNPJ, "rbTypeCNPJ");
            this.rbTypeCNPJ.Name = "rbTypeCNPJ";
            this.rbTypeCNPJ.UseSelectable = true;
            // 
            // metroPanel2
            // 
            this.metroPanel2.Controls.Add(this.pnLanguage);
            this.metroPanel2.Controls.Add(this.btClipboard);
            resources.ApplyResources(this.metroPanel2, "metroPanel2");
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // pnLanguage
            // 
            this.pnLanguage.Controls.Add(this.btLanguageEN);
            this.pnLanguage.Controls.Add(this.btLanguagePT);
            resources.ApplyResources(this.pnLanguage, "pnLanguage");
            this.pnLanguage.HorizontalScrollbarBarColor = true;
            this.pnLanguage.HorizontalScrollbarHighlightOnWheel = false;
            this.pnLanguage.HorizontalScrollbarSize = 10;
            this.pnLanguage.Name = "pnLanguage";
            this.pnLanguage.VerticalScrollbarBarColor = true;
            this.pnLanguage.VerticalScrollbarHighlightOnWheel = false;
            this.pnLanguage.VerticalScrollbarSize = 10;
            // 
            // btLanguageEN
            // 
            resources.ApplyResources(this.btLanguageEN, "btLanguageEN");
            this.btLanguageEN.Name = "btLanguageEN";
            this.btLanguageEN.UseSelectable = true;
            this.btLanguageEN.Click += new System.EventHandler(this.btLanguageEN_Click);
            // 
            // btLanguagePT
            // 
            resources.ApplyResources(this.btLanguagePT, "btLanguagePT");
            this.btLanguagePT.Name = "btLanguagePT";
            this.btLanguagePT.UseSelectable = true;
            this.btLanguagePT.Click += new System.EventHandler(this.btLanguagePT_Click);
            // 
            // btClipboard
            // 
            resources.ApplyResources(this.btClipboard, "btClipboard");
            this.btClipboard.Name = "btClipboard";
            this.btClipboard.UseSelectable = true;
            this.btClipboard.Click += new System.EventHandler(this.btClipboard_Click);
            // 
            // metroProgressSpinner1
            // 
            resources.ApplyResources(this.metroProgressSpinner1, "metroProgressSpinner1");
            this.metroProgressSpinner1.Maximum = 100;
            this.metroProgressSpinner1.Name = "metroProgressSpinner1";
            this.metroProgressSpinner1.UseSelectable = true;
            // 
            // CPF_CNPJ_Generator
            // 
            this.AcceptButton = this.btGenerate;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.metroPanel2);
            this.Controls.Add(this.pnMain);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.rtbResultado);
            this.Name = "CPF_CNPJ_Generator";
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.SystemShadow;
            this.Theme = MetroFramework.MetroThemeStyle.Default;
            this.Load += new System.EventHandler(this.CPF_CNPJ_Generator_Load);
            this.pnMain.ResumeLayout(false);
            this.metroPanel4.ResumeLayout(false);
            this.metroPanel4.PerformLayout();
            this.metroPanel3.ResumeLayout(false);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.metroPanel2.ResumeLayout(false);
            this.metroPanel2.PerformLayout();
            this.pnLanguage.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroTextBox rtbResultado;
        private MetroFramework.Controls.MetroLabel label5;
        private MetroFramework.Controls.MetroPanel pnMain;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroLabel lbType;
        private MetroFramework.Controls.MetroRadioButton rbTypeCPF;
        private MetroFramework.Controls.MetroRadioButton rbTypeCNPJ;
        private MetroFramework.Controls.MetroButton btGenerate;
        private MetroFramework.Controls.MetroPanel metroPanel4;
        private MetroFramework.Controls.MetroToggle tgMask;
        private MetroFramework.Controls.MetroLabel lbMask;
        private MetroFramework.Controls.MetroPanel metroPanel3;
        private MetroFramework.Controls.MetroTextBox txQuantidade;
        private MetroFramework.Controls.MetroLabel lbQuantity;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroButton btClipboard;
        private MetroFramework.Controls.MetroPanel pnLanguage;
        private MetroFramework.Controls.MetroButton btLanguageEN;
        private MetroFramework.Controls.MetroButton btLanguagePT;
        private MetroFramework.Controls.MetroProgressSpinner metroProgressSpinner1;
    }
}

