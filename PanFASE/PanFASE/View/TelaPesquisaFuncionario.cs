using System;
using System.Windows.Forms;

namespace PanFase
{
    public partial class TelaPesquisaFuncionario : Form
    {
        public Funcionario Func { get; set; }
        public TelaPesquisaFuncionario()
        {
            InitializeComponent();
            this.Func = new Funcionario();
            this.UpdateGrid();
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
            dt_GridFuncionario.DataSource = this.Func.UpdateGrid();
            dt_GridFuncionario.Columns[4].DefaultCellStyle.Format = "N2";
        }

        private void btn_pesquisarFuncionario_Click(object sender, EventArgs e)
        {
            if (rbt_nomeFunc.Checked)
            {
                dt_GridFuncionario.DataSource = this.Func.Pesquisar(tb_nomeFuncPesquisa.Text.Trim());
            }
            else if (rbt_CPFFunc.Checked)
            {
                string cpf = mtb_cpfpesquisafunc.Text.Trim();
                string[] split = cpf.Split(new Char[] { ',', '-' });
                cpf = string.Join("", split);
                long icpf = Convert.ToInt64(cpf);
                dt_GridFuncionario.DataSource = this.Func.Pesquisar(icpf);
            }
        }

        private void dt_GridFuncionario_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Func.Codigo = Convert.ToInt32(this.dt_GridFuncionario.Rows[e.RowIndex].Cells[0].Value);
            this.Func.Nome = Convert.ToString(this.dt_GridFuncionario.Rows[e.RowIndex].Cells[1].Value);
            this.Func.Cpf = Convert.ToString(this.dt_GridFuncionario.Rows[e.RowIndex].Cells[2].Value);
            this.Func.Admissao = Convert.ToString(this.dt_GridFuncionario.Rows[e.RowIndex].Cells[3].Value);
            this.Func.Salario = Convert.ToDouble(this.dt_GridFuncionario.Rows[e.RowIndex].Cells[4].Value);
            this.Func.Cargo = Convert.ToString(this.dt_GridFuncionario.Rows[e.RowIndex].Cells[5].Value);
            TelaUpdateFuncionario tufunc = new TelaUpdateFuncionario(this.Func);
            tufunc.ShowDialog();
            this.UpdateGrid();
        }
    }
}
