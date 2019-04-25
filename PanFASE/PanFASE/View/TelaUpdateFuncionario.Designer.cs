namespace PanFase
{
    partial class TelaUpdateFuncionario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaUpdateFuncionario));
            this.gb_funcionario = new System.Windows.Forms.GroupBox();
            this.tb_CodigoEdit = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_cargo = new System.Windows.Forms.Label();
            this.tb_CargoFuncEdit = new System.Windows.Forms.TextBox();
            this.btn_EditarFuncionario = new System.Windows.Forms.Button();
            this.mtb_SalarioEdit = new System.Windows.Forms.MaskedTextBox();
            this.dtp_DtAdmFuncEdit = new System.Windows.Forms.DateTimePicker();
            this.mtb_CpfFuncEdit = new System.Windows.Forms.MaskedTextBox();
            this.tb_NomeFuncEdit = new System.Windows.Forms.TextBox();
            this.lb_salario = new System.Windows.Forms.Label();
            this.lb_dataadm = new System.Windows.Forms.Label();
            this.Lb_cpffunc = new System.Windows.Forms.Label();
            this.lb_nomefunc = new System.Windows.Forms.Label();
            this.gb_funcionario.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_funcionario
            // 
            this.gb_funcionario.Controls.Add(this.tb_CodigoEdit);
            this.gb_funcionario.Controls.Add(this.label1);
            this.gb_funcionario.Controls.Add(this.lb_cargo);
            this.gb_funcionario.Controls.Add(this.tb_CargoFuncEdit);
            this.gb_funcionario.Controls.Add(this.btn_EditarFuncionario);
            this.gb_funcionario.Controls.Add(this.mtb_SalarioEdit);
            this.gb_funcionario.Controls.Add(this.dtp_DtAdmFuncEdit);
            this.gb_funcionario.Controls.Add(this.mtb_CpfFuncEdit);
            this.gb_funcionario.Controls.Add(this.tb_NomeFuncEdit);
            this.gb_funcionario.Controls.Add(this.lb_salario);
            this.gb_funcionario.Controls.Add(this.lb_dataadm);
            this.gb_funcionario.Controls.Add(this.Lb_cpffunc);
            this.gb_funcionario.Controls.Add(this.lb_nomefunc);
            this.gb_funcionario.Location = new System.Drawing.Point(12, 6);
            this.gb_funcionario.Name = "gb_funcionario";
            this.gb_funcionario.Size = new System.Drawing.Size(418, 255);
            this.gb_funcionario.TabIndex = 5;
            this.gb_funcionario.TabStop = false;
            this.gb_funcionario.Text = "Cadastro Funcionario";
            // 
            // tb_CodigoEdit
            // 
            this.tb_CodigoEdit.Enabled = false;
            this.tb_CodigoEdit.Location = new System.Drawing.Point(120, 24);
            this.tb_CodigoEdit.Name = "tb_CodigoEdit";
            this.tb_CodigoEdit.Size = new System.Drawing.Size(100, 20);
            this.tb_CodigoEdit.TabIndex = 14;
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
            // tb_CargoFuncEdit
            // 
            this.tb_CargoFuncEdit.Location = new System.Drawing.Point(120, 96);
            this.tb_CargoFuncEdit.Name = "tb_CargoFuncEdit";
            this.tb_CargoFuncEdit.Size = new System.Drawing.Size(282, 20);
            this.tb_CargoFuncEdit.TabIndex = 1;
            // 
            // btn_EditarFuncionario
            // 
            this.btn_EditarFuncionario.Location = new System.Drawing.Point(276, 212);
            this.btn_EditarFuncionario.Name = "btn_EditarFuncionario";
            this.btn_EditarFuncionario.Size = new System.Drawing.Size(126, 37);
            this.btn_EditarFuncionario.TabIndex = 10;
            this.btn_EditarFuncionario.Text = "Salvar";
            this.btn_EditarFuncionario.UseVisualStyleBackColor = true;
            this.btn_EditarFuncionario.Click += new System.EventHandler(this.btn_EditarFuncionario_Click);
            // 
            // mtb_SalarioEdit
            // 
            this.mtb_SalarioEdit.Location = new System.Drawing.Point(333, 181);
            this.mtb_SalarioEdit.Name = "mtb_SalarioEdit";
            this.mtb_SalarioEdit.Size = new System.Drawing.Size(69, 20);
            this.mtb_SalarioEdit.TabIndex = 5;
            // 
            // dtp_DtAdmFuncEdit
            // 
            this.dtp_DtAdmFuncEdit.Location = new System.Drawing.Point(120, 131);
            this.dtp_DtAdmFuncEdit.Name = "dtp_DtAdmFuncEdit";
            this.dtp_DtAdmFuncEdit.Size = new System.Drawing.Size(282, 20);
            this.dtp_DtAdmFuncEdit.TabIndex = 3;
            // 
            // mtb_CpfFuncEdit
            // 
            this.mtb_CpfFuncEdit.Location = new System.Drawing.Point(120, 178);
            this.mtb_CpfFuncEdit.Mask = "000.000.000-00";
            this.mtb_CpfFuncEdit.Name = "mtb_CpfFuncEdit";
            this.mtb_CpfFuncEdit.Size = new System.Drawing.Size(85, 20);
            this.mtb_CpfFuncEdit.TabIndex = 4;
            // 
            // tb_NomeFuncEdit
            // 
            this.tb_NomeFuncEdit.Location = new System.Drawing.Point(120, 59);
            this.tb_NomeFuncEdit.Name = "tb_NomeFuncEdit";
            this.tb_NomeFuncEdit.Size = new System.Drawing.Size(282, 20);
            this.tb_NomeFuncEdit.TabIndex = 0;
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
            // lb_dataadm
            // 
            this.lb_dataadm.AutoSize = true;
            this.lb_dataadm.Location = new System.Drawing.Point(18, 137);
            this.lb_dataadm.Name = "lb_dataadm";
            this.lb_dataadm.Size = new System.Drawing.Size(99, 13);
            this.lb_dataadm.TabIndex = 2;
            this.lb_dataadm.Text = "Data de Admissão :";
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
            // lb_nomefunc
            // 
            this.lb_nomefunc.AutoSize = true;
            this.lb_nomefunc.Location = new System.Drawing.Point(18, 62);
            this.lb_nomefunc.Name = "lb_nomefunc";
            this.lb_nomefunc.Size = new System.Drawing.Size(41, 13);
            this.lb_nomefunc.TabIndex = 0;
            this.lb_nomefunc.Text = "Nome :";
            // 
            // TelaUpdateFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 267);
            this.Controls.Add(this.gb_funcionario);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TelaUpdateFuncionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar Funcionario";
            this.Load += new System.EventHandler(this.TelaUpdateFuncionario_Load);
            this.gb_funcionario.ResumeLayout(false);
            this.gb_funcionario.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_funcionario;
        private System.Windows.Forms.TextBox tb_CodigoEdit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_cargo;
        private System.Windows.Forms.TextBox tb_CargoFuncEdit;
        private System.Windows.Forms.Button btn_EditarFuncionario;
        private System.Windows.Forms.MaskedTextBox mtb_SalarioEdit;
        private System.Windows.Forms.DateTimePicker dtp_DtAdmFuncEdit;
        private System.Windows.Forms.MaskedTextBox mtb_CpfFuncEdit;
        private System.Windows.Forms.TextBox tb_NomeFuncEdit;
        private System.Windows.Forms.Label lb_salario;
        private System.Windows.Forms.Label lb_dataadm;
        private System.Windows.Forms.Label Lb_cpffunc;
        private System.Windows.Forms.Label lb_nomefunc;
    }
}