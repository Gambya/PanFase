using PanFase.Data;
using System;
using System.Data;
using System.Windows.Forms;


namespace PanFase
{
    public class Cliente : Pessoa
    {
        public string dataCadastro { get; set; }

        public bool verificaDesconto()
        {
            bool retorno = false;
            var dataAtual = DateTime.Now;
            var dia = Convert.ToDateTime(dataCadastro);

            var dias = dataAtual.Subtract(dia).Days;
            if (dias > 180)
            {
                retorno = true;
            }
            return retorno;
        }

        public override long Cadastrar()
        {
            var id = new long();
            try
            {
                AcessoDados c = new AcessoDados();
                c.Sql = "insert into cliente(nome,cpf,dtcadastro)values('" + this.Nome + "','" + this.Cpf + "','" + this.dataCadastro + "')";
                id = c.Inserir();
                MessageBox.Show("Cliente cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro ao acessar Banco de dados: " + e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return id;
        }

        public override DataTable Pesquisar(string nome)
        {
            DataTable tclientes = new DataTable();
            try
            {
                AcessoDados conn = new AcessoDados();
                conn.Sql = "select codigo,nome,cpf,dtcadastro as cadastro from cliente where nome Like '%" + nome + "%'";
                tclientes = conn.selecionar();
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro ao acessar Banco de dados: " + e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return tclientes;
        }
        public override DataTable Pesquisar(long cpf)
        {
            DataTable tclientes = new DataTable();
            try
            {
                AcessoDados conn = new AcessoDados();
                conn.Sql = "select codigo,nome,cpf,dtcadastro as cadastro from cliente where cpf = '" + cpf + "'";
                tclientes = conn.selecionar();
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro ao acessar Banco de dados: " + e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return tclientes;
        }

        public override DataTable UpdateGrid()
        {
            DataTable tclientes = new DataTable();
            try
            {
                AcessoDados conn = new AcessoDados();
                conn.Sql = "select codigo,nome,cpf,dtcadastro as cadastro from cliente";
                tclientes = conn.selecionar();
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro ao acessar Banco de dados: " + e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return tclientes;
        }

        public override long Editar()
        {
            long id = new long();
            try
            {
                AcessoDados c = new AcessoDados();
                c.Sql = "update cliente set nome ='" + this.Nome + "',cpf = '" + this.Cpf + "',dtcadastro ='" + this.dataCadastro + "' where codigo = '" + this.Codigo + "'";
                id = c.UpdateSql();
                MessageBox.Show("Cliente atualizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro ao acessar Banco de dados: " + e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return id;
        }
    }
}