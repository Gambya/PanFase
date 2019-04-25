using System;
using System.Windows.Forms;

namespace PanFase
{
    public partial class TelaPesquisaCliente : Form
    {
        public Cliente Cliente { get; set; }
        public TelaPesquisaCliente()
        {
            InitializeComponent();
            this.Cliente = new Cliente();
            this.UpdateGrid();
        }

        
    
        private void rbt_nome_CheckedChanged(object sender, EventArgs e)
        {
            if (rbt_nomeCliente.Checked)
            {
            
                tb_nomeClientePesquisa.Visible = true;
                mtb_cpfClientePesquisa.Visible = false;
            }
            if (rbt_CPFCliente.Checked)
            {
                mtb_cpfClientePesquisa.Visible = true;
                tb_nomeClientePesquisa.Visible = false;
            }            
        }

        private void UpdateGrid()
        {
            dgv_pesquisaCliente.DataSource = this.Cliente.UpdateGrid();
        }

        private void btn_pesquisarCliente_Click(object sender, EventArgs e)
        {
            if (rbt_nomeCliente.Checked)
            {
                dgv_pesquisaCliente.DataSource = this.Cliente.Pesquisar(tb_nomeClientePesquisa.Text);
            }
            else if(rbt_CPFCliente.Checked)
            {
                string cpf = mtb_cpfClientePesquisa.Text.Trim();
                string[] split = cpf.Split(new Char[] { ',', '-' });
                cpf = string.Join("", split);
                long icpf = Convert.ToInt64(cpf);
                dgv_pesquisaCliente.DataSource = this.Cliente.Pesquisar(icpf);
            }
        }

        private void dgv_pesquisaCliente_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Cliente.Codigo = Convert.ToInt32(this.dgv_pesquisaCliente.Rows[e.RowIndex].Cells[0].Value);
            this.Cliente.Nome = Convert.ToString(this.dgv_pesquisaCliente.Rows[e.RowIndex].Cells[1].Value);
            this.Cliente.Cpf = Convert.ToString(this.dgv_pesquisaCliente.Rows[e.RowIndex].Cells[2].Value);
            this.Cliente.dataCadastro = Convert.ToString(this.dgv_pesquisaCliente.Rows[e.RowIndex].Cells[3].Value);
            TelaUpdateCliente tucliente = new TelaUpdateCliente(this.Cliente);
            tucliente.ShowDialog();
            this.UpdateGrid();
        }
    }
}
