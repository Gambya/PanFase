namespace PanFase
{
    partial class TelaUpdateCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaUpdateCliente));
            this.GB_CadastroCliente = new System.Windows.Forms.GroupBox();
            this.tb_Codigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_cadastrarcliente = new System.Windows.Forms.Button();
            this.mtb_CpfCliente = new System.Windows.Forms.MaskedTextBox();
            this.dtp_DataCadastroCliente = new System.Windows.Forms.DateTimePicker();
            this.Lb_DataCadastro = new System.Windows.Forms.Label();
            this.Lb_CPF = new System.Windows.Forms.Label();
            this.Lb_Nome = new System.Windows.Forms.Label();
            this.tb_NomeCliente = new System.Windows.Forms.TextBox();
            this.GB_CadastroCliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // GB_CadastroCliente
            // 
            this.GB_CadastroCliente.Controls.Add(this.tb_Codigo);
            this.GB_CadastroCliente.Controls.Add(this.label1);
            this.GB_CadastroCliente.Controls.Add(this.btn_cadastrarcliente);
            this.GB_CadastroCliente.Controls.Add(this.mtb_CpfCliente);
            this.GB_CadastroCliente.Controls.Add(this.dtp_DataCadastroCliente);
            this.GB_CadastroCliente.Controls.Add(this.Lb_DataCadastro);
            this.GB_CadastroCliente.Controls.Add(this.Lb_CPF);
            this.GB_CadastroCliente.Controls.Add(this.Lb_Nome);
            this.GB_CadastroCliente.Controls.Add(this.tb_NomeCliente);
            this.GB_CadastroCliente.Location = new System.Drawing.Point(10, 8);
            this.GB_CadastroCliente.Name = "GB_CadastroCliente";
            this.GB_CadastroCliente.Size = new System.Drawing.Size(365, 198);
            this.GB_CadastroCliente.TabIndex = 9;
            this.GB_CadastroCliente.TabStop = false;
            this.GB_CadastroCliente.Text = "Cadastro Cliente";
            // 
            // tb_Codigo
            // 
            this.tb_Codigo.Enabled = false;
            this.tb_Codigo.Location = new System.Drawing.Point(121, 14);
            this.tb_Codigo.Name = "tb_Codigo";
            this.tb_Codigo.Size = new System.Drawing.Size(67, 20);
            this.tb_Codigo.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Codigo:";
            // 
            // btn_cadastrarcliente
            // 
            this.btn_cadastrarcliente.Location = new System.Drawing.Point(233, 147);
            this.btn_cadastrarcliente.Name = "btn_cadastrarcliente";
            this.btn_cadastrarcliente.Size = new System.Drawing.Size(126, 37);
            this.btn_cadastrarcliente.TabIndex = 9;
            this.btn_cadastrarcliente.Text = "Salvar";
            this.btn_cadastrarcliente.UseVisualStyleBackColor = true;
            this.btn_cadastrarcliente.Click += new System.EventHandler(this.btn_cadastrarcliente_Click);
            // 
            // mtb_CpfCliente
            // 
            this.mtb_CpfCliente.Location = new System.Drawing.Point(121, 80);
            this.mtb_CpfCliente.Mask = "000.000.000-00";
            this.mtb_CpfCliente.Name = "mtb_CpfCliente";
            this.mtb_CpfCliente.Size = new System.Drawing.Size(238, 20);
            this.mtb_CpfCliente.TabIndex = 1;
            // 
            // dtp_DataCadastroCliente
            // 
            this.dtp_DataCadastroCliente.Location = new System.Drawing.Point(121, 112);
            this.dtp_DataCadastroCliente.Name = "dtp_DataCadastroCliente";
            this.dtp_DataCadastroCliente.Size = new System.Drawing.Size(238, 20);
            this.dtp_DataCadastroCliente.TabIndex = 2;
            // 
            // Lb_DataCadastro
            // 
            this.Lb_DataCadastro.AutoSize = true;
            this.Lb_DataCadastro.Location = new System.Drawing.Point(11, 116);
            this.Lb_DataCadastro.Name = "Lb_DataCadastro";
            this.Lb_DataCadastro.Size = new System.Drawing.Size(96, 13);
            this.Lb_DataCadastro.TabIndex = 5;
            this.Lb_DataCadastro.Text = "Data do Cadastro :";
            // 
            // Lb_CPF
            // 
            this.Lb_CPF.AutoSize = true;
            this.Lb_CPF.Location = new System.Drawing.Point(11, 86);
            this.Lb_CPF.Name = "Lb_CPF";
            this.Lb_CPF.Size = new System.Drawing.Size(36, 13);
            this.Lb_CPF.TabIndex = 4;
            this.Lb_CPF.Text = "CPF : ";
            // 
            // Lb_Nome
            // 
            this.Lb_Nome.AutoSize = true;
            this.Lb_Nome.Location = new System.Drawing.Point(11, 49);
            this.Lb_Nome.Name = "Lb_Nome";
            this.Lb_Nome.Size = new System.Drawing.Size(41, 13);
            this.Lb_Nome.TabIndex = 3;
            this.Lb_Nome.Text = "Nome :";
            // 
            // tb_NomeCliente
            // 
            this.tb_NomeCliente.Location = new System.Drawing.Point(121, 46);
            this.tb_NomeCliente.Name = "tb_NomeCliente";
            this.tb_NomeCliente.Size = new System.Drawing.Size(238, 20);
            this.tb_NomeCliente.TabIndex = 0;
            // 
            // TelaUpdateCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 214);
            this.Controls.Add(this.GB_CadastroCliente);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TelaUpdateCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar Cliente";
            this.Load += new System.EventHandler(this.TelaUpdateCliente_Load);
            this.GB_CadastroCliente.ResumeLayout(false);
            this.GB_CadastroCliente.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GB_CadastroCliente;
        private System.Windows.Forms.TextBox tb_Codigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_cadastrarcliente;
        private System.Windows.Forms.MaskedTextBox mtb_CpfCliente;
        private System.Windows.Forms.DateTimePicker dtp_DataCadastroCliente;
        private System.Windows.Forms.Label Lb_DataCadastro;
        private System.Windows.Forms.Label Lb_CPF;
        private System.Windows.Forms.Label Lb_Nome;
        private System.Windows.Forms.TextBox tb_NomeCliente;
    }
}