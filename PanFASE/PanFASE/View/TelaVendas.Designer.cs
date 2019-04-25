namespace PanFase
{
    partial class TelaVendas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaVendas));
            this.dtg_Pedido = new System.Windows.Forms.DataGridView();
            this.tb_ProdutoVendas = new System.Windows.Forms.TextBox();
            this.tb_Itens = new System.Windows.Forms.TextBox();
            this.tb_Total = new System.Windows.Forms.TextBox();
            this.gp_Comandos = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Pedido)).BeginInit();
            this.gp_Comandos.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtg_Pedido
            // 
            this.dtg_Pedido.AllowUserToAddRows = false;
            this.dtg_Pedido.AllowUserToDeleteRows = false;
            this.dtg_Pedido.AllowUserToResizeRows = false;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dtg_Pedido.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle17;
            this.dtg_Pedido.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtg_Pedido.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtg_Pedido.BackgroundColor = System.Drawing.Color.White;
            this.dtg_Pedido.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtg_Pedido.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle18;
            this.dtg_Pedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle19.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtg_Pedido.DefaultCellStyle = dataGridViewCellStyle19;
            this.dtg_Pedido.Location = new System.Drawing.Point(355, 86);
            this.dtg_Pedido.Name = "dtg_Pedido";
            this.dtg_Pedido.ReadOnly = true;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle20.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtg_Pedido.RowHeadersDefaultCellStyle = dataGridViewCellStyle20;
            this.dtg_Pedido.Size = new System.Drawing.Size(417, 463);
            this.dtg_Pedido.TabIndex = 4;
            // 
            // tb_ProdutoVendas
            // 
            this.tb_ProdutoVendas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_ProdutoVendas.BackColor = System.Drawing.Color.White;
            this.tb_ProdutoVendas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_ProdutoVendas.Font = new System.Drawing.Font("Arial Black", 28F, System.Drawing.FontStyle.Bold);
            this.tb_ProdutoVendas.ForeColor = System.Drawing.SystemColors.Highlight;
            this.tb_ProdutoVendas.Location = new System.Drawing.Point(12, 12);
            this.tb_ProdutoVendas.Name = "tb_ProdutoVendas";
            this.tb_ProdutoVendas.ReadOnly = true;
            this.tb_ProdutoVendas.Size = new System.Drawing.Size(760, 60);
            this.tb_ProdutoVendas.TabIndex = 5;
            this.tb_ProdutoVendas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_Itens
            // 
            this.tb_Itens.BackColor = System.Drawing.Color.White;
            this.tb_Itens.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_Itens.Font = new System.Drawing.Font("Arial Black", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Itens.ForeColor = System.Drawing.SystemColors.Highlight;
            this.tb_Itens.Location = new System.Drawing.Point(12, 86);
            this.tb_Itens.Name = "tb_Itens";
            this.tb_Itens.ReadOnly = true;
            this.tb_Itens.Size = new System.Drawing.Size(337, 49);
            this.tb_Itens.TabIndex = 6;
            this.tb_Itens.Text = "Insira Quantidade";
            this.tb_Itens.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_Total
            // 
            this.tb_Total.BackColor = System.Drawing.Color.White;
            this.tb_Total.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_Total.Font = new System.Drawing.Font("Arial Black", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Total.ForeColor = System.Drawing.Color.Red;
            this.tb_Total.Location = new System.Drawing.Point(12, 151);
            this.tb_Total.Name = "tb_Total";
            this.tb_Total.ReadOnly = true;
            this.tb_Total.Size = new System.Drawing.Size(337, 49);
            this.tb_Total.TabIndex = 7;
            this.tb_Total.Text = "R$ 0,00";
            this.tb_Total.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_Total.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TelaVendas_KeyDown);
            // 
            // gp_Comandos
            // 
            this.gp_Comandos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.gp_Comandos.BackColor = System.Drawing.Color.Transparent;
            this.gp_Comandos.Controls.Add(this.label6);
            this.gp_Comandos.Controls.Add(this.label5);
            this.gp_Comandos.Controls.Add(this.label4);
            this.gp_Comandos.Controls.Add(this.label3);
            this.gp_Comandos.Controls.Add(this.label2);
            this.gp_Comandos.Controls.Add(this.label1);
            this.gp_Comandos.Font = new System.Drawing.Font("Arial Black", 10F);
            this.gp_Comandos.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.gp_Comandos.Location = new System.Drawing.Point(12, 390);
            this.gp_Comandos.Name = "gp_Comandos";
            this.gp_Comandos.Size = new System.Drawing.Size(337, 159);
            this.gp_Comandos.TabIndex = 8;
            this.gp_Comandos.TabStop = false;
            this.gp_Comandos.Text = "Teclas de Atalho";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(149, 19);
            this.label6.TabIndex = 5;
            this.label6.Text = "[F6] Fechar Pedido";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(176, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "[F5] Pesquisar Cliente";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(175, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "[F4] Cadastrar Cliente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "[F3] Pesquisar Produto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "[F2] Cadastrar Produto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "[F1] Selecionar Funcionário";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::PanFase.Properties.Resources.logo;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Location = new System.Drawing.Point(12, 206);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(337, 178);
            this.panel1.TabIndex = 9;
            // 
            // TelaVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PanFase.Properties.Resources.padaria;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gp_Comandos);
            this.Controls.Add(this.tb_Total);
            this.Controls.Add(this.tb_Itens);
            this.Controls.Add(this.tb_ProdutoVendas);
            this.Controls.Add(this.dtg_Pedido);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "TelaVendas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TelaVendas_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Pedido)).EndInit();
            this.gp_Comandos.ResumeLayout(false);
            this.gp_Comandos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtg_Pedido;
        private System.Windows.Forms.TextBox tb_ProdutoVendas;
        private System.Windows.Forms.TextBox tb_Itens;
        private System.Windows.Forms.TextBox tb_Total;
        private System.Windows.Forms.GroupBox gp_Comandos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
    }
}