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
            this.label1 = new System.Windows.Forms.Label();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rtbResultado = new System.Windows.Forms.RichTextBox();
            this.btnCriar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbModelo = new System.Windows.Forms.ComboBox();
            this.cmbLinguas = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.chkbClear = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // cmbTipo
            // 
            resources.ApplyResources(this.cmbTipo, "cmbTipo");
            this.cmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Items.AddRange(new object[] {
            resources.GetString("cmbTipo.Items"),
            resources.GetString("cmbTipo.Items1")});
            this.cmbTipo.Name = "cmbTipo";
            // 
            // txtQuantidade
            // 
            resources.ApplyResources(this.txtQuantidade, "txtQuantidade");
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtQuantidade_KeyDown);
            this.txtQuantidade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuantidade_KeyPress);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // rtbResultado
            // 
            resources.ApplyResources(this.rtbResultado, "rtbResultado");
            this.rtbResultado.Name = "rtbResultado";
            // 
            // btnCriar
            // 
            resources.ApplyResources(this.btnCriar, "btnCriar");
            this.btnCriar.Name = "btnCriar";
            this.btnCriar.UseVisualStyleBackColor = true;
            this.btnCriar.Click += new System.EventHandler(this.btnCriar_Click);
            // 
            // btnLimpar
            // 
            resources.ApplyResources(this.btnLimpar, "btnLimpar");
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // cmbModelo
            // 
            resources.ApplyResources(this.cmbModelo, "cmbModelo");
            this.cmbModelo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbModelo.FormattingEnabled = true;
            this.cmbModelo.Items.AddRange(new object[] {
            resources.GetString("cmbModelo.Items"),
            resources.GetString("cmbModelo.Items1")});
            this.cmbModelo.Name = "cmbModelo";
            // 
            // cmbLinguas
            // 
            this.cmbLinguas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLinguas.FormattingEnabled = true;
            resources.ApplyResources(this.cmbLinguas, "cmbLinguas");
            this.cmbLinguas.Name = "cmbLinguas";
            this.cmbLinguas.SelectionChangeCommitted += new System.EventHandler(this.cmbLinguas_SelectionChangeCommitted);
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // chkbClear
            // 
            resources.ApplyResources(this.chkbClear, "chkbClear");
            this.chkbClear.Name = "chkbClear";
            this.chkbClear.UseVisualStyleBackColor = true;
            // 
            // CPF_CNPJ_Generator
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chkbClear);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbLinguas);
            this.Controls.Add(this.cmbModelo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCriar);
            this.Controls.Add(this.rtbResultado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtQuantidade);
            this.Controls.Add(this.cmbTipo);
            this.Controls.Add(this.label1);
            this.Name = "CPF_CNPJ_Generator";
            this.Load += new System.EventHandler(this.CPF_CNPJ_Generator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox rtbResultado;
        private System.Windows.Forms.Button btnCriar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbModelo;
        private System.Windows.Forms.ComboBox cmbLinguas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chkbClear;
    }
}

