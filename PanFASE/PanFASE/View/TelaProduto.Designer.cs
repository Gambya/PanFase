namespace PanFase
{
    partial class TelaProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaProduto));
            this.lb_codigo = new System.Windows.Forms.Label();
            this.lb_nomeproduto = new System.Windows.Forms.Label();
            this.gb_produto = new System.Windows.Forms.GroupBox();
            this.tb_ValorProd = new System.Windows.Forms.TextBox();
            this.lb_valor = new System.Windows.Forms.Label();
            this.btn_cadastrarproduto = new System.Windows.Forms.Button();
            this.mtb_Qtd = new System.Windows.Forms.MaskedTextBox();
            this.mtb_CodigoProd = new System.Windows.Forms.MaskedTextBox();
            this.tb_NomeProduto = new System.Windows.Forms.TextBox();
            this.lb_qtdproduto = new System.Windows.Forms.Label();
            this.gb_produto.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_codigo
            // 
            this.lb_codigo.AutoSize = true;
            this.lb_codigo.Location = new System.Drawing.Point(10, 32);
            this.lb_codigo.Name = "lb_codigo";
            this.lb_codigo.Size = new System.Drawing.Size(101, 13);
            this.lb_codigo.TabIndex = 0;
            this.lb_codigo.Text = "Codigo do Produto :";
            // 
            // lb_nomeproduto
            // 
            this.lb_nomeproduto.AutoSize = true;
            this.lb_nomeproduto.Location = new System.Drawing.Point(10, 74);
            this.lb_nomeproduto.Name = "lb_nomeproduto";
            this.lb_nomeproduto.Size = new System.Drawing.Size(41, 13);
            this.lb_nomeproduto.TabIndex = 1;
            this.lb_nomeproduto.Text = "Nome :";
            // 
            // gb_produto
            // 
            this.gb_produto.Controls.Add(this.tb_ValorProd);
            this.gb_produto.Controls.Add(this.lb_valor);
            this.gb_produto.Controls.Add(this.btn_cadastrarproduto);
            this.gb_produto.Controls.Add(this.mtb_Qtd);
            this.gb_produto.Controls.Add(this.mtb_CodigoProd);
            this.gb_produto.Controls.Add(this.tb_NomeProduto);
            this.gb_produto.Controls.Add(this.lb_qtdproduto);
            this.gb_produto.Controls.Add(this.lb_nomeproduto);
            this.gb_produto.Controls.Add(this.lb_codigo);
            this.gb_produto.Location = new System.Drawing.Point(12, 16);
            this.gb_produto.Name = "gb_produto";
            this.gb_produto.Size = new System.Drawing.Size(327, 199);
            this.gb_produto.TabIndex = 3;
            this.gb_produto.TabStop = false;
            this.gb_produto.Text = "Cadastro Produto";
            // 
            // tb_ValorProd
            // 
            this.tb_ValorProd.Location = new System.Drawing.Point(212, 110);
            this.tb_ValorProd.Name = "tb_ValorProd";
            this.tb_ValorProd.Size = new System.Drawing.Size(100, 20);
            this.tb_ValorProd.TabIndex = 2;
            this.tb_ValorProd.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // lb_valor
            // 
            this.lb_valor.AutoSize = true;
            this.lb_valor.Location = new System.Drawing.Point(164, 113);
            this.lb_valor.Name = "lb_valor";
            this.lb_valor.Size = new System.Drawing.Size(34, 13);
            this.lb_valor.TabIndex = 11;
            this.lb_valor.Text = "Valor:";
            // 
            // btn_cadastrarproduto
            // 
            this.btn_cadastrarproduto.Location = new System.Drawing.Point(186, 156);
            this.btn_cadastrarproduto.Name = "btn_cadastrarproduto";
            this.btn_cadastrarproduto.Size = new System.Drawing.Size(126, 37);
            this.btn_cadastrarproduto.TabIndex = 3;
            this.btn_cadastrarproduto.Text = "Cadastrar";
            this.btn_cadastrarproduto.UseVisualStyleBackColor = true;
            this.btn_cadastrarproduto.Click += new System.EventHandler(this.btn_cadastrarproduto_Click);
            // 
            // mtb_Qtd
            // 
            this.mtb_Qtd.Location = new System.Drawing.Point(117, 110);
            this.mtb_Qtd.Name = "mtb_Qtd";
            this.mtb_Qtd.Size = new System.Drawing.Size(28, 20);
            this.mtb_Qtd.TabIndex = 1;
            // 
            // mtb_CodigoProd
            // 
            this.mtb_CodigoProd.Enabled = false;
            this.mtb_CodigoProd.Location = new System.Drawing.Point(117, 32);
            this.mtb_CodigoProd.Name = "mtb_CodigoProd";
            this.mtb_CodigoProd.Size = new System.Drawing.Size(36, 20);
            this.mtb_CodigoProd.TabIndex = 4;
            this.mtb_CodigoProd.ValidatingType = typeof(int);
            // 
            // tb_NomeProduto
            // 
            this.tb_NomeProduto.Location = new System.Drawing.Point(117, 71);
            this.tb_NomeProduto.Name = "tb_NomeProduto";
            this.tb_NomeProduto.Size = new System.Drawing.Size(195, 20);
            this.tb_NomeProduto.TabIndex = 0;
            // 
            // lb_qtdproduto
            // 
            this.lb_qtdproduto.AutoSize = true;
            this.lb_qtdproduto.Location = new System.Drawing.Point(10, 113);
            this.lb_qtdproduto.Name = "lb_qtdproduto";
            this.lb_qtdproduto.Size = new System.Drawing.Size(68, 13);
            this.lb_qtdproduto.TabIndex = 2;
            this.lb_qtdproduto.Text = "Quantidade :";
            // 
            // TelaProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 227);
            this.Controls.Add(this.gb_produto);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TelaProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Produto";
            this.gb_produto.ResumeLayout(false);
            this.gb_produto.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lb_codigo;
        private System.Windows.Forms.Label lb_nomeproduto;
        private System.Windows.Forms.GroupBox gb_produto;
        private System.Windows.Forms.MaskedTextBox mtb_Qtd;
        private System.Windows.Forms.MaskedTextBox mtb_CodigoProd;
        private System.Windows.Forms.TextBox tb_NomeProduto;
        private System.Windows.Forms.Label lb_qtdproduto;
        private System.Windows.Forms.Button btn_cadastrarproduto;
        private System.Windows.Forms.TextBox tb_ValorProd;
        private System.Windows.Forms.Label lb_valor;
    }
}