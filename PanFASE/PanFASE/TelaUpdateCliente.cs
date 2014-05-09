using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PanFASE.com.merda.panfase.ADO;

namespace PanFASE
{
    public partial class TelaUpdateCliente : Form
    {
        public Cliente Cliente { get; set; }
        public TelaUpdateCliente(Cliente cliente)
        {
            InitializeComponent();
            this.Cliente = cliente;
        }

        private void btn_cadastrarcliente_Click(object sender, EventArgs e)
        {
            if (tb_NomeCliente.Text != "" && mtb_CpfCliente.Text != "")
            {
                this.Cliente.Nome = tb_NomeCliente.Text.Trim();
                string cpf = mtb_CpfCliente.Text.Trim();
                string[] split = cpf.Split(new Char[] { ',', '-' });
                cpf = string.Join("", split);
                this.Cliente.Cpf = cpf;
                string dt = string.Format("{0}-{1}-{2} {3}:{4}:{5}", dtp_DataCadastroCliente.Value.Year, dtp_DataCadastroCliente.Value.Month, dtp_DataCadastroCliente.Value.Day, dtp_DataCadastroCliente.Value.Hour, dtp_DataCadastroCliente.Value.Minute, dtp_DataCadastroCliente.Value.Second);
                this.Cliente.dtCadastro = dt;

                long id = this.Cliente.Editar();

                tb_Codigo.Text = Convert.ToString(id);
                tb_NomeCliente.Text = "";
                mtb_CpfCliente.Text = "";
                dtp_DataCadastroCliente.Value = DateTime.Now;
                this.Close();
            }
            else
            {
                MessageBox.Show(this, "Este campo precisa ser preenchido para que a atualização seja efetuado!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void TelaUpdateCliente_Load(object sender, EventArgs e)
        {
            tb_Codigo.Text = Convert.ToString(this.Cliente.Codigo);
            tb_NomeCliente.Text = this.Cliente.Nome;
            mtb_CpfCliente.Text = this.Cliente.Cpf;
            dtp_DataCadastroCliente.Value = Convert.ToDateTime(this.Cliente.dtCadastro);
        }
    }
}
