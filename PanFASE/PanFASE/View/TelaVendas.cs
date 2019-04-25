using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PanFase
{
    public partial class TelaVendas : Form
    {
        
        public PedidoProduto Pproduto { get; set; }
        public Produto Produto { get; set; }
        public Cliente Cliente { get; set; }
        public Funcionario Funcionario { get; set; }
        public TelaVendas()
        {
            InitializeComponent();
            this.Pproduto = new PedidoProduto();
            this.Produto = new Produto();
            this.Cliente = new Cliente();
            this.Funcionario = new Funcionario();
        }

        private void TelaVendas_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F1:
                    SelecionarFuncionario();
                    break;
                case Keys.F2:
                    CadastraProduto();
                    break;
                case Keys.F3:
                    PesquisaProduto();
                    break;
                case Keys.F4:
                    CadastraCliente();
                    break;
                case Keys.F5:
                    PesquisaCliente();
                    break;
                case Keys.F6:
                    FecharPedido();
                    break;
                case Keys.Enter:
                    SalvarNoPedido();
                    break;
            }
        }

        private void SelecionarFuncionario()
        {
            TelaPesquisaFuncionarioVendas pesquisaFuncionario = new TelaPesquisaFuncionarioVendas();
            pesquisaFuncionario.ShowDialog();
            this.Funcionario.Codigo = pesquisaFuncionario.Funcionario.Codigo;
            this.Funcionario.Nome = pesquisaFuncionario.Funcionario.Nome;
            this.Funcionario.Cpf = pesquisaFuncionario.Funcionario.Cpf;
            this.Funcionario.Cargo = pesquisaFuncionario.Funcionario.Cargo;
            this.Funcionario.Salario = pesquisaFuncionario.Funcionario.Salario;
            this.Funcionario.Admissao = pesquisaFuncionario.Funcionario.Admissao;
        }

        private void SalvarNoPedido()
        {
            if (this.tb_Itens.Text != "" && this.tb_Itens.Text != "Insira Quantidade")
            {
                this.Pproduto.Quantidade = Convert.ToDouble(this.tb_Itens.Text);
                this.Pproduto.ValorTotalProduto = this.Produto.Valor * this.Pproduto.Quantidade;

                this.dtg_Pedido.ColumnCount = 4;
                this.dtg_Pedido.Columns[0].Name = "Codigo";
                this.dtg_Pedido.Columns[1].Name = "Nome";
                this.dtg_Pedido.Columns[2].Name = "Quantidade";
                this.dtg_Pedido.Columns[3].Name = "Valor";
                this.dtg_Pedido.Columns[0].Width = 40;
                this.dtg_Pedido.Columns[2].DefaultCellStyle.Format = "N2";
                this.dtg_Pedido.Columns[3].DefaultCellStyle.Format = "c";
                if (!Pproduto.VerificaEstoque(this.Pproduto.CodigoPedidoProduto,this.Pproduto.Quantidade))
                {
                    MessageBox.Show("Quantidade de produto fora de Estoque.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.tb_Itens.Focus();
                }
                else
                {
                    this.dtg_Pedido.Rows.Add(Pproduto.CodigoPedidoProduto, Pproduto.Nome, Pproduto.Quantidade, Pproduto.ValorTotalProduto);
                    this.tb_Itens.Text = "";
                    decimal total = Convert.ToDecimal(0.00);
                    foreach (DataGridViewRow col in this.dtg_Pedido.Rows)
                    {
                        total += Convert.ToDecimal(col.Cells[3].Value);
                    }
                    this.tb_Total.Text = string.Format("{0:c}", total);
                    this.tb_Itens.Text = "Insira Quantidade";
                    this.tb_Itens.ReadOnly = true;
                }
            }
            else
            {
                MessageBox.Show(this, "É necessário preencher com a quantidade de itens desejada.", "Antenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void PesquisaCliente()
        {
            TelaPesquisaClienteVendas pesquisaCliente = new TelaPesquisaClienteVendas();
            pesquisaCliente.ShowDialog();
            this.Cliente = pesquisaCliente.Cliente;
        }

        private void PesquisaProduto()
        {
            TelaPesquisaProdutoVendas pesquisaProduto = new TelaPesquisaProdutoVendas();
            pesquisaProduto.ShowDialog();
            this.Produto = pesquisaProduto.Produto;
            this.tb_ProdutoVendas.Text = this.Produto.Nome;
            this.Pproduto.CodigoPedidoProduto = this.Produto.Codigo;
            this.Pproduto.Nome = this.Produto.Nome;
            
            this.tb_Itens.Text = "";
            this.tb_Itens.Enabled = true;
            this.tb_Itens.ReadOnly = false;
            this.tb_Itens.Focus();
        }

        private void CadastraProduto()
        {
            TelaProduto tproduto = new TelaProduto();
            tproduto.ShowDialog();
        }

        private void CadastraCliente()
        {
            TelaCliente tcliente = new TelaCliente();
            tcliente.ShowDialog();
        }

        private void FecharPedido()
        {
            if (this.Funcionario.Codigo == 0)
            {
                MessageBox.Show(this, "Entre com um funcionário para efetuar o fechamento do pedido","Atenção",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                this.SelecionarFuncionario();
                this.FecharPedido();
            }
            else
            {
                List<PedidoProduto> produtos = new List<PedidoProduto>();
                if (dtg_Pedido.Rows.Count > 0)
                {
                    for (int i = 0; i < dtg_Pedido.Rows.Count; i++)
                    {
                        PedidoProduto pedidoProduto = new PedidoProduto();
                        pedidoProduto.DtVenda = DateTime.Now;
                        pedidoProduto.Clientes = this.Cliente;
                        pedidoProduto.Funcionarios = this.Funcionario;
                        pedidoProduto.CodigoPedidoProduto = Convert.ToInt32(this.dtg_Pedido.Rows[i].Cells[0].Value);
                        pedidoProduto.Nome = Convert.ToString(this.dtg_Pedido.Rows[i].Cells[1].Value);
                        pedidoProduto.Quantidade = Convert.ToDouble(this.dtg_Pedido.Rows[i].Cells[2].Value);
                        pedidoProduto.ValorTotalProduto = Convert.ToDouble(this.dtg_Pedido.Rows[i].Cells[3].Value);
                        produtos.Add(pedidoProduto);
                        if (i == dtg_Pedido.Rows.Count - 1)
                        {
                            pedidoProduto.TirarPedido(produtos);
                        }
                    }
                    this.dtg_Pedido.DataSource = null;
                    this.dtg_Pedido.Rows.Clear();
                    this.tb_ProdutoVendas.Text = "";
                    this.tb_Total.Text = string.Format("{0:c}", "0,00");
                    this.Cliente = null;
                    MessageBox.Show(this, "Pedido fechado com sucesso!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(this, "É necessário ter produtos anexado ao pedido para que o mesmo possa ser fechado.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }
    }
}
