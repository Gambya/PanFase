using System;
using System.Windows.Forms;

namespace PanFase
{
    public partial class TelaUpdateProduto : Form
    {
        public Produto Produtos { get; set; }
        public TelaUpdateProduto(Produto produto)
        {
            InitializeComponent();
            Produtos = produto;
        }

        private void btn_EditarProduto_Click(object sender, EventArgs e)
        {
            if (tb_NomeProdutoEdit.Text != "" && tb_ValorProdEdit.Text != "" && mtb_QtdEdit.Text != "")
            {
                this.Produtos.Codigo = Convert.ToInt32(mtb_CodigoProdEdit.Text.Trim());
                this.Produtos.Nome = tb_NomeProdutoEdit.Text.Trim();
                this.Produtos.Estoque = Convert.ToDouble(mtb_QtdEdit.Text.Trim());
                string preco = tb_ValorProdEdit.Text;
                string[] ssplit = preco.Split(' ');
                preco = Convert.ToString(ssplit[1]);
                this.Produtos.Valor = Convert.ToDouble(preco);

                this.Produtos.Editar();
                this.Close();
            }
            else
            {
                MessageBox.Show(this, "Este campo precisa ser preenchido para que a atualização seja efetuado!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void TelaUpdateProduto_Load(object sender, EventArgs e)
        {
            this.mtb_CodigoProdEdit.Text = Convert.ToString(Produtos.Codigo);
            this.tb_NomeProdutoEdit.Text = Produtos.Nome;
            this.tb_ValorProdEdit.Text = string.Format("{0:c}",Produtos.Valor);
            this.mtb_QtdEdit.Text = string.Format("{0:N2}",Produtos.Estoque);
        }
    }
}
