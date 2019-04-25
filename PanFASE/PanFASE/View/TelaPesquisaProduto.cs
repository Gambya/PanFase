using System;
using System.Windows.Forms;

namespace PanFase
{
    public partial class TelaPesquisaProduto : Form
    {
        public Produto Produtos { get; set; }
        public TelaPesquisaProduto()
        {
            InitializeComponent();
            this.Produtos = new Produto();
            this.UpdateGrid();
        }

        private void btn_pesquisarProduto_Click(object sender, EventArgs e)
        {
            if (rbt_nomeprodutopesquisa.Checked)
            {
                dt_DataGridProduto.DataSource = this.Produtos.pesquisaProduto(tb_nomeprodutopesquisa.Text);
            }
            else if(rbt_codigoprodutopesquisa.Checked)
            {
                dt_DataGridProduto.DataSource = this.Produtos.pesquisaProduto(Convert.ToInt32(mtb_codigoprodutopesquisa.Text));
            }
        }

        private void rbt_nomeprodutopesquisa_CheckedChanged(object sender, EventArgs e)
        {
            if (rbt_nomeprodutopesquisa.Checked)
            {
                tb_nomeprodutopesquisa.Visible = true;
                mtb_codigoprodutopesquisa.Visible = false;
            } if (rbt_codigoprodutopesquisa.Checked)
            {
                tb_nomeprodutopesquisa.Visible = false;
                mtb_codigoprodutopesquisa.Visible = true;
            }
        }

        private void UpdateGrid()
        {
            dt_DataGridProduto.DataSource = this.Produtos.UpdateGrid();
            dt_DataGridProduto.Columns[2].DefaultCellStyle.Format = "N2";
            dt_DataGridProduto.Columns[3].DefaultCellStyle.Format = "c";
        }

        private void dt_DataGridProduto_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Produtos.Codigo = Convert.ToInt32(this.dt_DataGridProduto.Rows[e.RowIndex].Cells[0].Value);
            this.Produtos.Nome = Convert.ToString(this.dt_DataGridProduto.Rows[e.RowIndex].Cells[1].Value);
            this.Produtos.Estoque = Convert.ToDouble(this.dt_DataGridProduto.Rows[e.RowIndex].Cells[2].Value);
            this.Produtos.Valor = Convert.ToDouble(this.dt_DataGridProduto.Rows[e.RowIndex].Cells[3].Value);
            TelaUpdateProduto tuproduto = new TelaUpdateProduto(this.Produtos);
            tuproduto.ShowDialog();
            this.UpdateGrid();
        }
    }
}
