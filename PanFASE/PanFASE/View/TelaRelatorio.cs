using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PanFase
{
    public partial class TelaRelatorio : Form
    {
        public string inicio { get; set; }
        public string fim { get; set; }
        public TelaRelatorio(string inicio, string fim)
        {
            InitializeComponent();
            this.inicio = inicio;
            this.fim = fim;
        }

        private void bt_gerarRelatorio_Click(object sender, EventArgs e)
        {
        }

        private void TelaRelatorio_Load(object sender, EventArgs e)
        {
            RPedidoProduto p = new RPedidoProduto();
            PedidoProdutoBindingSource.DataSource = p.GetPedidos(this.inicio,this.fim);
            this.rv_relatorio.RefreshReport();
        }

        private void dtp_datafinal_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
