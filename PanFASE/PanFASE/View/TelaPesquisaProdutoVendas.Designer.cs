namespace PanFase
{
    partial class TelaPesquisaProdutoVendas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaPesquisaProdutoVendas));
            this.btn_pesquisarProduto = new System.Windows.Forms.Button();
            this.dt_DataGridProduto = new System.Windows.Forms.DataGridView();
            this.gb_pesquisaproduto = new System.Windows.Forms.GroupBox();
            this.rbt_nomeprodutopesquisa = new System.Windows.Forms.RadioButton();
            this.rbt_codigoprodutopesquisa = new System.Windows.Forms.RadioButton();
            this.mtb_codigoprodutopesquisa = new System.Windows.Forms.MaskedTextBox();
            this.tb_nomeprodutopesquisa = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dt_DataGridProduto)).BeginInit();
            this.gb_pesquisaproduto.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_pesquisarProduto
            // 
            this.btn_pesquisarProduto.Location = new System.Drawing.Point(577, 42);
            this.btn_pesquisarProduto.Name = "btn_pesquisarProduto";
            this.btn_pesquisarProduto.Size = new System.Drawing.Size(125, 40);
            this.btn_pesquisarProduto.TabIndex = 6;
            this.btn_pesquisarProduto.Text = "Pesquisar";
            this.btn_pesquisarProduto.UseVisualStyleBackColor = true;
            this.btn_pesquisarProduto.Click += new System.EventHandler(this.btn_pesquisarProduto_Click);
            // 
            // dt_DataGridProduto
            // 
            this.dt_DataGridProduto.AllowDrop = true;
            this.dt_DataGridProduto.AllowUserToAddRows = false;
            this.dt_DataGridProduto.AllowUserToDeleteRows = false;
            this.dt_DataGridProduto.AllowUserToResizeColumns = false;
            this.dt_DataGridProduto.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dt_DataGridProduto.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dt_DataGridProduto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dt_DataGridProduto.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dt_DataGridProduto.DefaultCellStyle = dataGridViewCellStyle3;
            this.dt_DataGridProduto.Location = new System.Drawing.Point(12, 88);
            this.dt_DataGridProduto.MultiSelect = false;
            this.dt_DataGridProduto.Name = "dt_DataGridProduto";
            this.dt_DataGridProduto.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dt_DataGridProduto.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dt_DataGridProduto.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dt_DataGridProduto.RowTemplate.ReadOnly = true;
            this.dt_DataGridProduto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dt_DataGridProduto.Size = new System.Drawing.Size(690, 276);
            this.dt_DataGridProduto.TabIndex = 8;
            this.dt_DataGridProduto.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dt_DataGridProduto_CellDoubleClick);
            // 
            // gb_pesquisaproduto
            // 
            this.gb_pesquisaproduto.Controls.Add(this.rbt_nomeprodutopesquisa);
            this.gb_pesquisaproduto.Controls.Add(this.rbt_codigoprodutopesquisa);
            this.gb_pesquisaproduto.Location = new System.Drawing.Point(12, 7);
            this.gb_pesquisaproduto.Name = "gb_pesquisaproduto";
            this.gb_pesquisaproduto.Size = new System.Drawing.Size(129, 75);
            this.gb_pesquisaproduto.TabIndex = 7;
            this.gb_pesquisaproduto.TabStop = false;
            this.gb_pesquisaproduto.Text = "Pesquisa Produto";
            // 
            // rbt_nomeprodutopesquisa
            // 
            this.rbt_nomeprodutopesquisa.AutoSize = true;
            this.rbt_nomeprodutopesquisa.Checked = true;
            this.rbt_nomeprodutopesquisa.Location = new System.Drawing.Point(7, 43);
            this.rbt_nomeprodutopesquisa.Name = "rbt_nomeprodutopesquisa";
            this.rbt_nomeprodutopesquisa.Size = new System.Drawing.Size(108, 17);
            this.rbt_nomeprodutopesquisa.TabIndex = 1;
            this.rbt_nomeprodutopesquisa.TabStop = true;
            this.rbt_nomeprodutopesquisa.Text = "Nome do Produto";
            this.rbt_nomeprodutopesquisa.UseVisualStyleBackColor = true;
            // 
            // rbt_codigoprodutopesquisa
            // 
            this.rbt_codigoprodutopesquisa.AutoSize = true;
            this.rbt_codigoprodutopesquisa.Location = new System.Drawing.Point(7, 20);
            this.rbt_codigoprodutopesquisa.Name = "rbt_codigoprodutopesquisa";
            this.rbt_codigoprodutopesquisa.Size = new System.Drawing.Size(98, 17);
            this.rbt_codigoprodutopesquisa.TabIndex = 0;
            this.rbt_codigoprodutopesquisa.Text = "Codigo Produto";
            this.rbt_codigoprodutopesquisa.UseVisualStyleBackColor = true;
            this.rbt_codigoprodutopesquisa.CheckedChanged += new System.EventHandler(this.rbt_codigoprodutopesquisa_CheckedChanged);
            // 
            // mtb_codigoprodutopesquisa
            // 
            this.mtb_codigoprodutopesquisa.Location = new System.Drawing.Point(147, 62);
            this.mtb_codigoprodutopesquisa.Mask = "00000";
            this.mtb_codigoprodutopesquisa.Name = "mtb_codigoprodutopesquisa";
            this.mtb_codigoprodutopesquisa.Size = new System.Drawing.Size(36, 20);
            this.mtb_codigoprodutopesquisa.TabIndex = 4;
            this.mtb_codigoprodutopesquisa.ValidatingType = typeof(int);
            this.mtb_codigoprodutopesquisa.Visible = false;
            // 
            // tb_nomeprodutopesquisa
            // 
            this.tb_nomeprodutopesquisa.Location = new System.Drawing.Point(147, 62);
            this.tb_nomeprodutopesquisa.Name = "tb_nomeprodutopesquisa";
            this.tb_nomeprodutopesquisa.Size = new System.Drawing.Size(424, 20);
            this.tb_nomeprodutopesquisa.TabIndex = 5;
            // 
            // TelaPesquisaProdutoVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 375);
            this.Controls.Add(this.btn_pesquisarProduto);
            this.Controls.Add(this.dt_DataGridProduto);
            this.Controls.Add(this.gb_pesquisaproduto);
            this.Controls.Add(this.mtb_codigoprodutopesquisa);
            this.Controls.Add(this.tb_nomeprodutopesquisa);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TelaPesquisaProdutoVendas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pesquisa de Produtos";
            ((System.ComponentModel.ISupportInitialize)(this.dt_DataGridProduto)).EndInit();
            this.gb_pesquisaproduto.ResumeLayout(false);
            this.gb_pesquisaproduto.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_pesquisarProduto;
        private System.Windows.Forms.DataGridView dt_DataGridProduto;
        private System.Windows.Forms.GroupBox gb_pesquisaproduto;
        private System.Windows.Forms.RadioButton rbt_nomeprodutopesquisa;
        private System.Windows.Forms.RadioButton rbt_codigoprodutopesquisa;
        private System.Windows.Forms.MaskedTextBox mtb_codigoprodutopesquisa;
        private System.Windows.Forms.TextBox tb_nomeprodutopesquisa;
    }
}