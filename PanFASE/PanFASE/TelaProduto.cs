using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PanFASE.com.merda.panfase.ADO;

namespace PanFASE
{
    public partial class TelaProduto : Form
    {
        public TelaProduto()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_cadastrarproduto_Click(object sender, EventArgs e)
        {
            if (tb_NomeProduto.Text != "" && mtb_Qtd.Text != "" && tb_ValorProd.Text != "")
            {
                Produto prod = new Produto();
                prod.Nome = tb_NomeProduto.Text.Trim();
                prod.Estoque = Convert.ToDouble(mtb_Qtd.Text.Trim());
                prod.Valor = Convert.ToDouble(tb_ValorProd.Text.Trim());

                long id = prod.CadastrarProduto();

                mtb_CodigoProd.Text = Convert.ToString(id + 1);
                tb_NomeProduto.Text = "";
                mtb_Qtd.Text = "";
                tb_ValorProd.Text = "";
            }
            else
            {
                MessageBox.Show(this, "Este campo precisa ser preenchido para que o cadastro seja efetuado!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
