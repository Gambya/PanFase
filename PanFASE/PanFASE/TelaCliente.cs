﻿using System;
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
    public partial class TelaCliente : Form
    {
        public TelaCliente()
        {
            InitializeComponent();
        }

        private void btn_cadastrarcliente_Click(object sender, EventArgs e)
        {
            if (tb_NomeCliente.Text != "" && mtb_CpfCliente.Text != "")
            {
                Cliente cliente = new Cliente();
                cliente.Nome = tb_NomeCliente.Text.Trim();
                string cpf = mtb_CpfCliente.Text.Trim();
                string[] split = cpf.Split(new Char[] { ',', '-' });
                cpf = string.Join("", split);
                cliente.Cpf = cpf;
                string dt = string.Format("{0}-{1}-{2} {3}:{4}:{5}", dtp_DataCadastroCliente.Value.Year, dtp_DataCadastroCliente.Value.Month, dtp_DataCadastroCliente.Value.Day, dtp_DataCadastroCliente.Value.Hour, dtp_DataCadastroCliente.Value.Minute, dtp_DataCadastroCliente.Value.Second);
                cliente.dtCadastro = dt;

                long id = cliente.Cadastrar();

                tb_Codigo.Text = Convert.ToString(id + 1);
                tb_NomeCliente.Text = "";
                mtb_CpfCliente.Text = "";
                dtp_DataCadastroCliente.Value = DateTime.Now;
            }
            else
            {
                MessageBox.Show(this, "Este campo precisa ser preenchido para que o cadastro seja efetuado!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
