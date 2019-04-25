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
    public partial class TelaPrincipal : Form
    {
        public TelaPrincipal()
        {
            InitializeComponent();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length > 0)
            {
                this.ActiveMdiChild.Close();
            }
            TelaCliente telaCliente = new  TelaCliente();
            telaCliente.MdiParent = this;
            telaCliente.Show();
        }

        private void funcionarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length > 0)
            {
                this.ActiveMdiChild.Close();
            }
            TelaFuncionario telaFuncionario = new TelaFuncionario();
            telaFuncionario.MdiParent = this;
            telaFuncionario.Show();
        }

        private void produtoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length > 0)
            {
                this.ActiveMdiChild.Close();
            }
            TelaProduto telaProduto = new TelaProduto();
            telaProduto.MdiParent = this;
            telaProduto.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void clienteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length > 0)
            {
                this.ActiveMdiChild.Close();
            }
            TelaPesquisaCliente telaPesquisaCliente = new TelaPesquisaCliente();
            telaPesquisaCliente.MdiParent = this;
            telaPesquisaCliente.Show();
        }

        private void funcionarioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length > 0)
            {
                this.ActiveMdiChild.Close();
            }
            TelaPesquisaFuncionario telapesquisafunc = new TelaPesquisaFuncionario();
            telapesquisafunc.MdiParent = this;
            telapesquisafunc.Show();
        }

        private void produtoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length > 0)
            {
                this.ActiveMdiChild.Close();
            }
            TelaPesquisaProduto tela = new TelaPesquisaProduto();
            tela.MdiParent = this;
            tela.Show();
        }

        private void relatorioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelaPeriodo relatorio = new TelaPeriodo();
            relatorio.ShowDialog();
        }

        private void vendasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelaVendas vendas = new TelaVendas();
            vendas.ShowDialog();
        }
    }
}
