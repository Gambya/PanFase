namespace PanFase
{
    partial class TelaRelatorio
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaRelatorio));
            this.rv_relatorio = new Microsoft.Reporting.WinForms.ReportViewer();
            this.PedidoProdutoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PedidoProdutoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // rv_relatorio
            // 
            this.rv_relatorio.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rv_relatorio.AutoScroll = true;
            this.rv_relatorio.AutoSize = true;
            reportDataSource1.Name = "dtsetPedido";
            reportDataSource1.Value = this.PedidoProdutoBindingSource;
            this.rv_relatorio.LocalReport.DataSources.Add(reportDataSource1);
            this.rv_relatorio.LocalReport.ReportEmbeddedResource = "PanFase.Relatorio_Vendas.rdlc";
            this.rv_relatorio.Location = new System.Drawing.Point(0, 0);
            this.rv_relatorio.Margin = new System.Windows.Forms.Padding(10);
            this.rv_relatorio.Name = "rv_relatorio";
            this.rv_relatorio.Size = new System.Drawing.Size(649, 391);
            this.rv_relatorio.TabIndex = 9;
            // 
            // PedidoProdutoBindingSource
            // 
            this.PedidoProdutoBindingSource.DataSource = typeof(PanFase.PedidoProduto);
            // 
            // TelaRelatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 390);
            this.Controls.Add(this.rv_relatorio);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TelaRelatorio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatorio de Vendas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.TelaRelatorio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PedidoProdutoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rv_relatorio;
        private System.Windows.Forms.BindingSource PedidoProdutoBindingSource;
    }
}