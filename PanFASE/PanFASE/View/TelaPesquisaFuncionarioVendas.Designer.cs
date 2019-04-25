namespace PanFase
{
    partial class TelaPesquisaFuncionarioVendas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaPesquisaFuncionarioVendas));
            this.btn_pesquisarFuncionario = new System.Windows.Forms.Button();
            this.mtb_cpfpesquisafunc = new System.Windows.Forms.MaskedTextBox();
            this.tb_nomeFuncPesquisa = new System.Windows.Forms.TextBox();
            this.dt_GridFuncionario = new System.Windows.Forms.DataGridView();
            this.gb_tipodepesquisafunc = new System.Windows.Forms.GroupBox();
            this.rbt_nomeFunc = new System.Windows.Forms.RadioButton();
            this.rbt_CPFFunc = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dt_GridFuncionario)).BeginInit();
            this.gb_tipodepesquisafunc.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_pesquisarFuncionario
            // 
            this.btn_pesquisarFuncionario.Location = new System.Drawing.Point(460, 15);
            this.btn_pesquisarFuncionario.Name = "btn_pesquisarFuncionario";
            this.btn_pesquisarFuncionario.Size = new System.Drawing.Size(125, 40);
            this.btn_pesquisarFuncionario.TabIndex = 6;
            this.btn_pesquisarFuncionario.Text = "Pesquisar";
            this.btn_pesquisarFuncionario.UseVisualStyleBackColor = true;
            this.btn_pesquisarFuncionario.Click += new System.EventHandler(this.btn_pesquisarFuncionario_Click);
            // 
            // mtb_cpfpesquisafunc
            // 
            this.mtb_cpfpesquisafunc.Location = new System.Drawing.Point(161, 35);
            this.mtb_cpfpesquisafunc.Mask = "000.000.000-00";
            this.mtb_cpfpesquisafunc.Name = "mtb_cpfpesquisafunc";
            this.mtb_cpfpesquisafunc.Size = new System.Drawing.Size(83, 20);
            this.mtb_cpfpesquisafunc.TabIndex = 5;
            this.mtb_cpfpesquisafunc.Visible = false;
            // 
            // tb_nomeFuncPesquisa
            // 
            this.tb_nomeFuncPesquisa.Location = new System.Drawing.Point(161, 35);
            this.tb_nomeFuncPesquisa.Name = "tb_nomeFuncPesquisa";
            this.tb_nomeFuncPesquisa.Size = new System.Drawing.Size(293, 20);
            this.tb_nomeFuncPesquisa.TabIndex = 4;
            // 
            // dt_GridFuncionario
            // 
            this.dt_GridFuncionario.AllowUserToAddRows = false;
            this.dt_GridFuncionario.AllowUserToDeleteRows = false;
            this.dt_GridFuncionario.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dt_GridFuncionario.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dt_GridFuncionario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dt_GridFuncionario.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dt_GridFuncionario.DefaultCellStyle = dataGridViewCellStyle3;
            this.dt_GridFuncionario.Location = new System.Drawing.Point(12, 61);
            this.dt_GridFuncionario.MultiSelect = false;
            this.dt_GridFuncionario.Name = "dt_GridFuncionario";
            this.dt_GridFuncionario.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dt_GridFuncionario.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dt_GridFuncionario.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dt_GridFuncionario.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dt_GridFuncionario.RowTemplate.ReadOnly = true;
            this.dt_GridFuncionario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dt_GridFuncionario.Size = new System.Drawing.Size(573, 247);
            this.dt_GridFuncionario.TabIndex = 8;
            this.dt_GridFuncionario.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dt_GridFuncionario_CellDoubleClick);
            // 
            // gb_tipodepesquisafunc
            // 
            this.gb_tipodepesquisafunc.Controls.Add(this.rbt_nomeFunc);
            this.gb_tipodepesquisafunc.Controls.Add(this.rbt_CPFFunc);
            this.gb_tipodepesquisafunc.Location = new System.Drawing.Point(12, 8);
            this.gb_tipodepesquisafunc.Name = "gb_tipodepesquisafunc";
            this.gb_tipodepesquisafunc.Size = new System.Drawing.Size(143, 47);
            this.gb_tipodepesquisafunc.TabIndex = 7;
            this.gb_tipodepesquisafunc.TabStop = false;
            this.gb_tipodepesquisafunc.Text = "Tipo de Pesquisa";
            // 
            // rbt_nomeFunc
            // 
            this.rbt_nomeFunc.AutoSize = true;
            this.rbt_nomeFunc.Checked = true;
            this.rbt_nomeFunc.Location = new System.Drawing.Point(6, 21);
            this.rbt_nomeFunc.Name = "rbt_nomeFunc";
            this.rbt_nomeFunc.Size = new System.Drawing.Size(53, 17);
            this.rbt_nomeFunc.TabIndex = 0;
            this.rbt_nomeFunc.TabStop = true;
            this.rbt_nomeFunc.Text = "Nome";
            this.rbt_nomeFunc.UseVisualStyleBackColor = true;
            this.rbt_nomeFunc.CheckedChanged += new System.EventHandler(this.rbt_nomeFunc_CheckedChanged);
            // 
            // rbt_CPFFunc
            // 
            this.rbt_CPFFunc.AutoSize = true;
            this.rbt_CPFFunc.Location = new System.Drawing.Point(78, 21);
            this.rbt_CPFFunc.Name = "rbt_CPFFunc";
            this.rbt_CPFFunc.Size = new System.Drawing.Size(45, 17);
            this.rbt_CPFFunc.TabIndex = 1;
            this.rbt_CPFFunc.Text = "CPF";
            this.rbt_CPFFunc.UseVisualStyleBackColor = true;
            // 
            // TelaPesquisaFuncionarioVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 316);
            this.Controls.Add(this.btn_pesquisarFuncionario);
            this.Controls.Add(this.mtb_cpfpesquisafunc);
            this.Controls.Add(this.tb_nomeFuncPesquisa);
            this.Controls.Add(this.dt_GridFuncionario);
            this.Controls.Add(this.gb_tipodepesquisafunc);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TelaPesquisaFuncionarioVendas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pesquisa de Funcionario";
            ((System.ComponentModel.ISupportInitialize)(this.dt_GridFuncionario)).EndInit();
            this.gb_tipodepesquisafunc.ResumeLayout(false);
            this.gb_tipodepesquisafunc.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_pesquisarFuncionario;
        private System.Windows.Forms.MaskedTextBox mtb_cpfpesquisafunc;
        private System.Windows.Forms.TextBox tb_nomeFuncPesquisa;
        private System.Windows.Forms.DataGridView dt_GridFuncionario;
        private System.Windows.Forms.GroupBox gb_tipodepesquisafunc;
        private System.Windows.Forms.RadioButton rbt_nomeFunc;
        private System.Windows.Forms.RadioButton rbt_CPFFunc;
    }
}