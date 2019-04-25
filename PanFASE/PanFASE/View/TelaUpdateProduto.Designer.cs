namespace PanFase
{
    partial class TelaUpdateProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaUpdateProduto));
            this.gb_produto = new System.Windows.Forms.GroupBox();
            this.tb_ValorProdEdit = new System.Windows.Forms.TextBox();
            this.lb_valor = new System.Windows.Forms.Label();
            this.btn_EditarProduto = new System.Windows.Forms.Button();
            this.mtb_QtdEdit = new System.Windows.Forms.MaskedTextBox();
            this.mtb_CodigoProdEdit = new System.Windows.Forms.MaskedTextBox();
            this.tb_NomeProdutoEdit = new System.Windows.Forms.TextBox();
            this.lb_qtdproduto = new System.Windows.Forms.Label();
            this.lb_nomeproduto = new System.Windows.Forms.Label();
            this.lb_codigo = new System.Windows.Forms.Label();
            this.gb_produto.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_produto
            // 
            this.gb_produto.Controls.Add(this.tb_ValorProdEdit);
            this.gb_produto.Controls.Add(this.lb_valor);
            this.gb_produto.Controls.Add(this.btn_EditarProduto);
            this.gb_produto.Controls.Add(this.mtb_QtdEdit);
            this.gb_produto.Controls.Add(this.mtb_CodigoProdEdit);
            this.gb_produto.Controls.Add(this.tb_NomeProdutoEdit);
            this.gb_produto.Controls.Add(this.lb_qtdproduto);
            this.gb_produto.Controls.Add(this.lb_nomeproduto);
            this.gb_produto.Controls.Add(this.lb_codigo);
            this.gb_produto.Location = new System.Drawing.Point(11, 14);
            this.gb_produto.Name = "gb_produto";
            this.gb_produto.Size = new System.Drawing.Size(327, 199);
            this.gb_produto.TabIndex = 4;
            this.gb_produto.TabStop = false;
            this.gb_produto.Text = "Cadastro Produto";
            // 
            // tb_ValorProdEdit
            // 
            this.tb_ValorProdEdit.Location = new System.Drawing.Point(212, 110);
            this.tb_ValorProdEdit.Name = "tb_ValorProdEdit";
            this.tb_ValorProdEdit.Size = new System.Drawing.Size(100, 20);
            this.tb_ValorProdEdit.TabIndex = 2;
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
            // btn_EditarProduto
            // 
            this.btn_EditarProduto.Location = new System.Drawing.Point(186, 156);
            this.btn_EditarProduto.Name = "btn_EditarProduto";
            this.btn_EditarProduto.Size = new System.Drawing.Size(126, 37);
            this.btn_EditarProduto.TabIndex = 3;
            this.btn_EditarProduto.Text = "Salvar";
            this.btn_EditarProduto.UseVisualStyleBackColor = true;
            this.btn_EditarProduto.Click += new System.EventHandler(this.btn_EditarProduto_Click);
            // 
            // mtb_QtdEdit
            // 
            this.mtb_QtdEdit.Location = new System.Drawing.Point(117, 110);
            this.mtb_QtdEdit.Name = "mtb_QtdEdit";
            this.mtb_QtdEdit.Size = new System.Drawing.Size(28, 20);
            this.mtb_QtdEdit.TabIndex = 1;
            // 
            // mtb_CodigoProdEdit
            // 
            this.mtb_CodigoProdEdit.Enabled = false;
            this.mtb_CodigoProdEdit.Location = new System.Drawing.Point(117, 32);
            this.mtb_CodigoProdEdit.Name = "mtb_CodigoProdEdit";
            this.mtb_CodigoProdEdit.Size = new System.Drawing.Size(36, 20);
            this.mtb_CodigoProdEdit.TabIndex = 4;
            this.mtb_CodigoProdEdit.ValidatingType = typeof(int);
            // 
            // tb_NomeProdutoEdit
            // 
            this.tb_NomeProdutoEdit.Location = new System.Drawing.Point(117, 71);
            this.tb_NomeProdutoEdit.Name = "tb_NomeProdutoEdit";
            this.tb_NomeProdutoEdit.Size = new System.Drawing.Size(195, 20);
            this.tb_NomeProdutoEdit.TabIndex = 0;
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
            // lb_nomeproduto
            // 
            this.lb_nomeproduto.AutoSize = true;
            this.lb_nomeproduto.Location = new System.Drawing.Point(10, 74);
            this.lb_nomeproduto.Name = "lb_nomeproduto";
            this.lb_nomeproduto.Size = new System.Drawing.Size(41, 13);
            this.lb_nomeproduto.TabIndex = 1;
            this.lb_nomeproduto.Text = "Nome :";
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
            // TelaUpdateProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 227);
            this.Controls.Add(this.gb_produto);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TelaUpdateProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar Produto";
            this.Load += new System.EventHandler(this.TelaUpdateProduto_Load);
            this.gb_produto.ResumeLayout(false);
            this.gb_produto.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_produto;
        private System.Windows.Forms.TextBox tb_ValorProdEdit;
        private System.Windows.Forms.Label lb_valor;
        private System.Windows.Forms.Button btn_EditarProduto;
        private System.Windows.Forms.MaskedTextBox mtb_QtdEdit;
        private System.Windows.Forms.MaskedTextBox mtb_CodigoProdEdit;
        private System.Windows.Forms.TextBox tb_NomeProdutoEdit;
        private System.Windows.Forms.Label lb_qtdproduto;
        private System.Windows.Forms.Label lb_nomeproduto;
        private System.Windows.Forms.Label lb_codigo;
    }
}