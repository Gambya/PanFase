using System;
using System.Windows.Forms;

namespace PanFase
{
    public partial class TelaFuncionario : Form
    {
        public TelaFuncionario()
        {
            InitializeComponent();
        }

        private void btn_cadastrarfuncionario_Click(object sender, EventArgs e)
        {
            if (tb_NomeFunc.Text != "" && mtb_CpfFunc.Text != "" && mtb_Salario.Text != "" && tb_CargoFunc.Text != "")
            {
                Funcionario func = new Funcionario();
                func.Nome = tb_NomeFunc.Text.Trim();
                func.Cargo = tb_CargoFunc.Text.Trim();
                string dt = string.Format("{0:yyyy-MM-dd HH:mm:ss}", dtp_DtAdmFunc.Value);
                func.Admissao = dt;
                string cpf = mtb_CpfFunc.Text.Trim();
                string[] split = cpf.Split(new Char[] { ',', '-' });
                cpf = string.Join("", split);
                func.Cpf = cpf;
                func.Salario = Convert.ToDouble(mtb_Salario.Text);

                long id = func.Cadastrar();

                tb_Codigo.Text = Convert.ToString(id + 1);
                tb_NomeFunc.Text = "";
                tb_CargoFunc.Text = "";
                dtp_DtAdmFunc.Value = DateTime.Now;
                mtb_CpfFunc.Text = "";
                mtb_Salario.Text = "";
            }
            else
            {
                MessageBox.Show(this, "Este campo precisa ser preenchido para que o cadastro seja efetuado!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
