using System;
using System.Windows.Forms;

namespace PanFase
{
    public partial class TelaUpdateFuncionario : Form
    {
        public Funcionario Func { get; set; }
        public TelaUpdateFuncionario(Funcionario func)
        {
            InitializeComponent();
            this.Func = func;
        }

        private void btn_EditarFuncionario_Click(object sender, EventArgs e)
        {
            if (tb_NomeFuncEdit.Text != "" && mtb_CpfFuncEdit.Text != "" && mtb_SalarioEdit.Text != "" && tb_CargoFuncEdit.Text != "")
            {
                this.Func.Nome = tb_NomeFuncEdit.Text.Trim();
                this.Func.Cargo = tb_CargoFuncEdit.Text.Trim();
                string dateTimeFormat = "{0}-{1}-{2} {3}:{4}:{5}";
                this.Func.Admissao = string.Format(dateTimeFormat, dtp_DtAdmFuncEdit.Value.Year, dtp_DtAdmFuncEdit.Value.Month, dtp_DtAdmFuncEdit.Value.Day, dtp_DtAdmFuncEdit.Value.Hour, dtp_DtAdmFuncEdit.Value.Minute, dtp_DtAdmFuncEdit.Value.Second);
                string cpf = mtb_CpfFuncEdit.Text.Trim();
                string[] split = cpf.Split(new Char[] { ',', '-' });
                cpf = string.Join("", split);
                this.Func.Cpf = cpf;
                string salario = mtb_SalarioEdit.Text;
                string[] ssplit = salario.Split(' ');
                salario = Convert.ToString(ssplit[1]);
                this.Func.Salario = Convert.ToDouble(salario);

                long id = this.Func.Editar();
                this.Close();
            }
            else
            {
                MessageBox.Show(this, "Este campo precisa ser preenchido para que a atualização seja efetuado!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void TelaUpdateFuncionario_Load(object sender, EventArgs e)
        {
            this.tb_CodigoEdit.Text = Convert.ToString(this.Func.Codigo);
            this.tb_NomeFuncEdit.Text = this.Func.Nome;
            this.tb_CargoFuncEdit.Text = this.Func.Cargo;
            this.dtp_DtAdmFuncEdit.Value = Convert.ToDateTime(this.Func.Admissao);
            this.mtb_CpfFuncEdit.Text = this.Func.Cpf;
            this.mtb_SalarioEdit.Text = string.Format("{0:c}", this.Func.Salario);
        }
    }
}
