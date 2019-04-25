using PanFase.Data;
using System;
using System.Data;
using System.Windows.Forms;


namespace PanFase
{
    public class Funcionario : Pessoa
    {
        public string Admissao { get; set; }
        public double Salario { get; set; }
        public string Cargo { get; set; }

        void AumentaSalario(double salario)
        {
            if (this.Salario < salario)
            {
                this.Salario = salario;
            }
            else
            {
                this.Salario += salario;
            }
        }

        public override long Cadastrar()
        {
            long id = new long();
            try
            {
                AcessoDados f = new AcessoDados();
                f.Sql = "insert into funcionario(nome,cpf,admissao,salario,cargo)values('" + this.Nome + "','" + this.Cpf + "','" + this.Admissao + "','" + this.Salario + "','" + this.Cargo + "')";
                id = f.Inserir();
                MessageBox.Show("Funcionário cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro ao acessar Banco de dados: " + e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return id;
        }

        public override DataTable Pesquisar(string nome)
        {
            DataTable tfuncionario = new DataTable();
            try
            {
                AcessoDados conn = new AcessoDados();
                conn.Sql = "select codigo as Codigo,nome as Nome,cpf as Cpf,admissao as Admissão,cargo as Cargo,salario as Salário from funcionario where nome Like '%" + nome + "%'";
                tfuncionario = conn.selecionar();
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro ao acessar Banco de dados: " + e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return tfuncionario;
        }
        public override DataTable Pesquisar(long cpf)
        {
            DataTable tfuncionario = new DataTable();
            try
            {
                AcessoDados conn = new AcessoDados();
                conn.Sql = "select codigo as Codigo,nome as Nome,cpf as Cpf,admissao as Admissão,cargo as Cargo,salario as Salário from funcionario where cpf = '" + cpf + "'";
                tfuncionario = conn.selecionar();
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro ao acessar Banco de dados: " + e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return tfuncionario;
        }

        public override DataTable UpdateGrid()
        {
            DataTable tfuncionario = new DataTable();
            try
            {
                AcessoDados conn = new AcessoDados();
                conn.Sql = "select codigo as Codigo,nome as Nome,cpf as Cpf,admissao as Admissão,salario as Salário,cargo as Cargo from funcionario";
                tfuncionario = conn.selecionar();
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro ao acessar Banco de dados: " + e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return tfuncionario;
        }
        public override long Editar()
        {
            long id = new long();
            try
            {
                AcessoDados f = new AcessoDados();
                f.Sql = "update funcionario set nome = '" + this.Nome + "',cpf = '" + this.Cpf + "',admissao = '" + this.Admissao + "',salario = '" + this.Salario + "',cargo = '" + this.Cargo + "' where codigo = '" + this.Codigo + "'";
                id = f.UpdateSql();
                MessageBox.Show("Funcionario atualizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro ao acessar Banco de dados: " + e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return id;
        }
    }

}