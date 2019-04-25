using System;
using System.Windows.Forms;

namespace PanFase
{
    public partial class TelaPesquisaFuncionarioVendas : Form
    {
        public Funcionario Funcionario { get; set; }
        public TelaPesquisaFuncionarioVendas()
        {
            InitializeComponent();
            this.Funcionario = new Funcionario();
            UpdateGrid();
        }

        private void rbt_nomeFunc_CheckedChanged(object sender, EventArgs e)
        {

            if (rbt_nomeFunc.Checked)
            {

                tb_nomeFuncPesquisa.Visible = true;
                mtb_cpfpesquisafunc.Visible = false;
            }
            if (rbt_CPFFunc.Checked)
            {
                mtb_cpfpesquisafunc.Visible = true;
                tb_nomeFuncPesquisa.Visible = false;
            }
        }

        private void UpdateGrid()
        {
            dt_GridFuncionario.DataSource = this.Funcionario.UpdateGrid();
            dt_GridFuncionario.Columns[4].DefaultCellStyle.Format = "c";
        }

        private void btn_pesquisarFuncionario_Click(object sender, EventArgs e)
        {
            if (rbt_nomeFunc.Checked)
            {
                dt_GridFuncionario.DataSource = this.Funcionario.Pesquisar(tb_nomeFuncPesquisa.Text.Trim());
            }
            else if (rbt_CPFFunc.Checked)
            {
                string cpf = mtb_cpfpesquisafunc.Text.Trim();
                string[] split = cpf.Split(new Char[] { ',', '-' });
                cpf = string.Join("", split);
                long icpf = Convert.ToInt64(cpf);
                dt_GridFuncionario.DataSource = this.Funcionario.Pesquisar(icpf);
            }
        }

        private void dt_GridFuncionario_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Funcionario.Codigo = Convert.ToInt32(dt_GridFuncionario.Rows[e.RowIndex].Cells[0].Value);
            this.Funcionario.Nome = Convert.ToString(dt_GridFuncionario.Rows[e.RowIndex].Cells[1].Value);
            this.Funcionario.Cpf = Convert.ToString(dt_GridFuncionario.Rows[e.RowIndex].Cells[2].Value);
            this.Funcionario.Admissao = Convert.ToString(dt_GridFuncionario.Rows[e.RowIndex].Cells[3].Value);
            this.Funcionario.Cargo = Convert.ToString(dt_GridFuncionario.Rows[e.RowIndex].Cells[5].Value);
            this.Funcionario.Salario = Convert.ToDouble(dt_GridFuncionario.Rows[e.RowIndex].Cells[4].Value);
            this.Close();
        }
    }
}
