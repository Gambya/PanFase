using System;
using System.Windows.Forms;
using PanFase.Data;

namespace PanFase
{
    public partial class TelaPesquisaProdutoVendas : Form
    {
        public Produto Produto { get; set; }
        
        public TelaPesquisaProdutoVendas()
        {
            InitializeComponent();
            this.Produto = new Produto();
            this.UpdateGrid();
        }

        private void rbt_codigoprodutopesquisa_CheckedChanged(object sender, EventArgs e)
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
            dt_DataGridProduto.DataSource = this.Produto.UpdateGrid();
            dt_DataGridProduto.Columns[2].DefaultCellStyle.Format = "N2";
            dt_DataGridProduto.Columns[3].DefaultCellStyle.Format = "c";
        }

        private void btn_pesquisarProduto_Click(object sender, EventArgs e)
        {
            var conn = new AcessoDados();
            if (rbt_nomeprodutopesquisa.Checked)
            {
                dt_DataGridProduto.DataSource = this.Produto.pesquisaProduto(tb_nomeprodutopesquisa.Text.Trim());
            }
            else if (rbt_codigoprodutopesquisa.Checked)
            {
                if (mtb_codigoprodutopesquisa.Text == "")
                {
                    MessageBox.Show(this, "Problema na Interface: Preencher campo com um código válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    dt_DataGridProduto.DataSource = this.Produto.pesquisaProduto(Convert.ToInt32(mtb_codigoprodutopesquisa.Text));
                }
            }
        }

        private void dt_DataGridProduto_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Produto.Codigo = Convert.ToInt32(this.dt_DataGridProduto.Rows[e.RowIndex].Cells[0].Value);
            this.Produto.Nome = this.dt_DataGridProduto.Rows[e.RowIndex].Cells[1].Value.ToString();
            this.Produto.Estoque = Convert.ToDouble(this.dt_DataGridProduto.Rows[e.RowIndex].Cells[2].Value.ToString());
            this.Produto.Valor = Convert.ToDouble(this.dt_DataGridProduto.Rows[e.RowIndex].Cells[3].Value.ToString());
            this.Close();
        }
    }
}
