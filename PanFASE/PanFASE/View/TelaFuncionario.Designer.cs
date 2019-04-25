namespace PanFase
{
    partial class TelaFuncionario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaFuncionario));
            this.lb_nomefunc = new System.Windows.Forms.Label();
            this.Lb_cpffunc = new System.Windows.Forms.Label();
            this.lb_dataadm = new System.Windows.Forms.Label();
            this.lb_salario = new System.Windows.Forms.Label();
            this.gb_funcionario = new System.Windows.Forms.GroupBox();
            this.tb_Codigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_cargo = new System.Windows.Forms.Label();
            this.tb_CargoFunc = new System.Windows.Forms.TextBox();
            this.btn_cadastrarfuncionario = new System.Windows.Forms.Button();
            this.mtb_Salario = new System.Windows.Forms.MaskedTextBox();
            this.dtp_DtAdmFunc = new System.Windows.Forms.DateTimePicker();
            this.mtb_CpfFunc = new System.Windows.Forms.MaskedTextBox();
            this.tb_NomeFunc = new System.Windows.Forms.TextBox();
            this.gb_funcionario.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_nomefunc
            // 
            this.lb_nomefunc.AutoSize = true;
            this.lb_nomefunc.Location = new System.Drawing.Point(18, 62);
            this.lb_nomefunc.Name = "lb_nomefunc";
            this.lb_nomefunc.Size = new System.Drawing.Size(41, 13);
            this.lb_nomefunc.TabIndex = 0;
            this.lb_nomefunc.Text = "Nome :";
            // 
            // Lb_cpffunc
            // 
            this.Lb_cpffunc.AutoSize = true;
            this.Lb_cpffunc.Location = new System.Drawing.Point(18, 181);
            this.Lb_cpffunc.Name = "Lb_cpffunc";
            this.Lb_cpffunc.Size = new System.Drawing.Size(33, 13);
            this.Lb_cpffunc.TabIndex = 1;
            this.Lb_cpffunc.Text = "CPF :";
            // 
            // lb_dataadm
            // 
            this.lb_dataadm.AutoSize = true;
            this.lb_dataadm.Location = new System.Drawing.Point(18, 137);
            this.lb_dataadm.Name = "lb_dataadm";
            this.lb_dataadm.Size = new System.Drawing.Size(99, 13);
            this.lb_dataadm.TabIndex = 2;
            this.lb_dataadm.Text = "Data de Admissão :";
            // 
            // lb_salario
            // 
            this.lb_salario.AutoSize = true;
            this.lb_salario.Location = new System.Drawing.Point(233, 184);
            this.lb_salario.Name = "lb_salario";
            this.lb_salario.Size = new System.Drawing.Size(45, 13);
            this.lb_salario.TabIndex = 3;
            this.lb_salario.Text = "Salário :";
            // 
            // gb_funcionario
            // 
            this.gb_funcionario.Controls.Add(this.tb_Codigo);
            this.gb_funcionario.Controls.Add(this.label1);
            this.gb_funcionario.Controls.Add(this.lb_cargo);
            this.gb_funcionario.Controls.Add(this.tb_CargoFunc);
            this.gb_funcionario.Controls.Add(this.btn_cadastrarfuncionario);
            this.gb_funcionario.Controls.Add(this.mtb_Salario);
            this.gb_funcionario.Controls.Add(this.dtp_DtAdmFunc);
            this.gb_funcionario.Controls.Add(this.mtb_CpfFunc);
            this.gb_funcionario.Controls.Add(this.tb_NomeFunc);
            this.gb_funcionario.Controls.Add(this.lb_salario);
            this.gb_funcionario.Controls.Add(this.lb_dataadm);
            this.gb_funcionario.Controls.Add(this.Lb_cpffunc);
            this.gb_funcionario.Controls.Add(this.lb_nomefunc);
            this.gb_funcionario.Location = new System.Drawing.Point(12, 0);
            this.gb_funcionario.Name = "gb_funcionario";
            this.gb_funcionario.Size = new System.Drawing.Size(418, 255);
            this.gb_funcionario.TabIndex = 4;
            this.gb_funcionario.TabStop = false;
            this.gb_funcionario.Text = "Cadastro Funcionario";
            // 
            // tb_Codigo
            // 
            this.tb_Codigo.Enabled = false;
            this.tb_Codigo.Location = new System.Drawing.Point(120, 24);
            this.tb_Codigo.Name = "tb_Codigo";
            this.tb_Codigo.Size = new System.Drawing.Size(100, 20);
            this.tb_Codigo.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Codigo:";
            // 
            // lb_cargo
            // 
            this.lb_cargo.AutoSize = true;
            this.lb_cargo.Location = new System.Drawing.Point(18, 99);
            this.lb_cargo.Name = "lb_cargo";
            this.lb_cargo.Size = new System.Drawing.Size(38, 13);
            this.lb_cargo.TabIndex = 12;
            this.lb_cargo.Text = "Cargo:";
            // 
            // tb_CargoFunc
            // 
            this.tb_CargoFunc.Location = new System.Drawing.Point(120, 96);
            this.tb_CargoFunc.Name = "tb_CargoFunc";
            this.tb_CargoFunc.Size = new System.Drawing.Size(282, 20);
            this.tb_CargoFunc.TabIndex = 1;
            // 
            // btn_cadastrarfuncionario
            // 
            this.btn_cadastrarfuncionario.Location = new System.Drawing.Point(276, 212);
            this.btn_cadastrarfuncionario.Name = "btn_cadastrarfuncionario";
            this.btn_cadastrarfuncionario.Size = new System.Drawing.Size(126, 37);
            this.btn_cadastrarfuncionario.TabIndex = 10;
            this.btn_cadastrarfuncionario.Text = "Cadastrar";
            this.btn_cadastrarfuncionario.UseVisualStyleBackColor = true;
            this.btn_cadastrarfuncionario.Click += new System.EventHandler(this.btn_cadastrarfuncionario_Click);
            // 
            // mtb_Salario
            // 
            this.mtb_Salario.Location = new System.Drawing.Point(333, 181);
            this.mtb_Salario.Name = "mtb_Salario";
            this.mtb_Salario.Size = new System.Drawing.Size(69, 20);
            this.mtb_Salario.TabIndex = 5;
            // 
            // dtp_DtAdmFunc
            // 
            this.dtp_DtAdmFunc.Location = new System.Drawing.Point(120, 131);
            this.dtp_DtAdmFunc.Name = "dtp_DtAdmFunc";
            this.dtp_DtAdmFunc.Size = new System.Drawing.Size(282, 20);
            this.dtp_DtAdmFunc.TabIndex = 3;
            // 
            // mtb_CpfFunc
            // 
            this.mtb_CpfFunc.Location = new System.Drawing.Point(120, 178);
            this.mtb_CpfFunc.Mask = "000.000.000-00";
            this.mtb_CpfFunc.Name = "mtb_CpfFunc";
            this.mtb_CpfFunc.Size = new System.Drawing.Size(85, 20);
            this.mtb_CpfFunc.TabIndex = 4;
            // 
            // tb_NomeFunc
            // 
            this.tb_NomeFunc.Location = new System.Drawing.Point(120, 59);
            this.tb_NomeFunc.Name = "tb_NomeFunc";
            this.tb_NomeFunc.Size = new System.Drawing.Size(282, 20);
            this.tb_NomeFunc.TabIndex = 0;
            // 
            // TelaFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 267);
            this.Controls.Add(this.gb_funcionario);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TelaFuncionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Funcionário";
            this.gb_funcionario.ResumeLayout(false);
            this.gb_funcionario.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lb_nomefunc;
        private System.Windows.Forms.Label Lb_cpffunc;
        private System.Windows.Forms.Label lb_dataadm;
        private System.Windows.Forms.Label lb_salario;
        private System.Windows.Forms.GroupBox gb_funcionario;
        private System.Windows.Forms.DateTimePicker dtp_DtAdmFunc;
        private System.Windows.Forms.MaskedTextBox mtb_CpfFunc;
        private System.Windows.Forms.TextBox tb_NomeFunc;
        private System.Windows.Forms.MaskedTextBox mtb_Salario;
        private System.Windows.Forms.Button btn_cadastrarfuncionario;
        private System.Windows.Forms.Label lb_cargo;
        private System.Windows.Forms.TextBox tb_CargoFunc;
        private System.Windows.Forms.TextBox tb_Codigo;
        private System.Windows.Forms.Label label1;
    }
}