namespace PanFase
{
    partial class TelaPesquisaClienteVendas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaPesquisaClienteVendas));
            this.btn_pesquisarCliente = new System.Windows.Forms.Button();
            this.dgv_pesquisaCliente = new System.Windows.Forms.DataGridView();
            this.gb_pesquisa = new System.Windows.Forms.GroupBox();
            this.rbt_CPFCliente = new System.Windows.Forms.RadioButton();
            this.rbt_nomeCliente = new System.Windows.Forms.RadioButton();
            this.mtb_cpfClientePesquisa = new System.Windows.Forms.MaskedTextBox();
            this.tb_nomeClientePesquisa = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_pesquisaCliente)).BeginInit();
            this.gb_pesquisa.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_pesquisarCliente
            // 
            this.btn_pesquisarCliente.Location = new System.Drawing.Point(456, 8);
            this.btn_pesquisarCliente.Name = "btn_pesquisarCliente";
            this.btn_pesquisarCliente.Size = new System.Drawing.Size(125, 42);
            this.btn_pesquisarCliente.TabIndex = 9;
            this.btn_pesquisarCliente.Text = "Pesquisar";
            this.btn_pesquisarCliente.UseVisualStyleBackColor = true;
            this.btn_pesquisarCliente.Click += new System.EventHandler(this.btn_pesquisarCliente_Click);
            // 
            // dgv_pesquisaCliente
            // 
            this.dgv_pesquisaCliente.AllowUserToAddRows = false;
            this.dgv_pesquisaCliente.AllowUserToDeleteRows = false;
            this.dgv_pesquisaCliente.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgv_pesquisaCliente.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_pesquisaCliente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_pesquisaCliente.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_pesquisaCliente.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_pesquisaCliente.Location = new System.Drawing.Point(10, 56);
            this.dgv_pesquisaCliente.Name = "dgv_pesquisaCliente";
            this.dgv_pesquisaCliente.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_pesquisaCliente.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgv_pesquisaCliente.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_pesquisaCliente.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgv_pesquisaCliente.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgv_pesquisaCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_pesquisaCliente.Size = new System.Drawing.Size(571, 220);
            this.dgv_pesquisaCliente.TabIndex = 11;
            this.dgv_pesquisaCliente.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_pesquisaCliente_CellDoubleClick);
            // 
            // gb_pesquisa
            // 
            this.gb_pesquisa.Controls.Add(this.rbt_CPFCliente);
            this.gb_pesquisa.Controls.Add(this.rbt_nomeCliente);
            this.gb_pesquisa.Location = new System.Drawing.Point(10, 8);
            this.gb_pesquisa.Name = "gb_pesquisa";
            this.gb_pesquisa.Size = new System.Drawing.Size(119, 42);
            this.gb_pesquisa.TabIndex = 10;
            this.gb_pesquisa.TabStop = false;
            this.gb_pesquisa.Text = "Tipo De Pesquisa";
            // 
            // rbt_CPFCliente
            // 
            this.rbt_CPFCliente.AutoSize = true;
            this.rbt_CPFCliente.Location = new System.Drawing.Point(68, 18);
            this.rbt_CPFCliente.Name = "rbt_CPFCliente";
            this.rbt_CPFCliente.Size = new System.Drawing.Size(45, 17);
            this.rbt_CPFCliente.TabIndex = 4;
            this.rbt_CPFCliente.Text = "CPF";
            this.rbt_CPFCliente.UseVisualStyleBackColor = true;
            // 
            // rbt_nomeCliente
            // 
            this.rbt_nomeCliente.AutoSize = true;
            this.rbt_nomeCliente.Checked = true;
            this.rbt_nomeCliente.Location = new System.Drawing.Point(6, 18);
            this.rbt_nomeCliente.Name = "rbt_nomeCliente";
            this.rbt_nomeCliente.Size = new System.Drawing.Size(53, 17);
            this.rbt_nomeCliente.TabIndex = 3;
            this.rbt_nomeCliente.TabStop = true;
            this.rbt_nomeCliente.Text = "Nome";
            this.rbt_nomeCliente.UseVisualStyleBackColor = true;
            this.rbt_nomeCliente.CheckedChanged += new System.EventHandler(this.rbt_nome_CheckedChanged);
            // 
            // mtb_cpfClientePesquisa
            // 
            this.mtb_cpfClientePesquisa.Location = new System.Drawing.Point(141, 30);
            this.mtb_cpfClientePesquisa.Mask = "000.000.000-00";
            this.mtb_cpfClientePesquisa.Name = "mtb_cpfClientePesquisa";
            this.mtb_cpfClientePesquisa.Size = new System.Drawing.Size(118, 20);
            this.mtb_cpfClientePesquisa.TabIndex = 8;
            this.mtb_cpfClientePesquisa.Visible = false;
            // 
            // tb_nomeClientePesquisa
            // 
            this.tb_nomeClientePesquisa.Location = new System.Drawing.Point(141, 30);
            this.tb_nomeClientePesquisa.Name = "tb_nomeClientePesquisa";
            this.tb_nomeClientePesquisa.Size = new System.Drawing.Size(303, 20);
            this.tb_nomeClientePesquisa.TabIndex = 7;
            // 
            // TelaPesquisaClienteVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 285);
            this.Controls.Add(this.btn_pesquisarCliente);
            this.Controls.Add(this.dgv_pesquisaCliente);
            this.Controls.Add(this.gb_pesquisa);
            this.Controls.Add(this.mtb_cpfClientePesquisa);
            this.Controls.Add(this.tb_nomeClientePesquisa);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TelaPesquisaClienteVendas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pesquisa Clientes";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_pesquisaCliente)).EndInit();
            this.gb_pesquisa.ResumeLayout(false);
            this.gb_pesquisa.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_pesquisarCliente;
        private System.Windows.Forms.DataGridView dgv_pesquisaCliente;
        private System.Windows.Forms.GroupBox gb_pesquisa;
        private System.Windows.Forms.RadioButton rbt_CPFCliente;
        private System.Windows.Forms.RadioButton rbt_nomeCliente;
        private System.Windows.Forms.MaskedTextBox mtb_cpfClientePesquisa;
        private System.Windows.Forms.TextBox tb_nomeClientePesquisa;
    }
}