using PanFase.Data;
using System;
using System.Data;
using System.Windows.Forms;


namespace PanFase
{
    public class Produto
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public double Valor { get; set; }
        public double Estoque { get; set; }

        public long CadastrarProduto()
        {
            long id = 0;
            try
            {
                AcessoDados p = new AcessoDados();
                p.Sql = "insert into produto(nome,valor,estoque)values('" + this.Nome + "','" + this.Valor + "','" + this.Estoque + "')";
                id = p.Inserir();
                MessageBox.Show("Produto cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro ao acessar Banco de dados: "+e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return id;
        }

        public DataTable pesquisaProduto(string nome)
        {
            DataTable tproduto = new DataTable();
            try
            {
                AcessoDados conn = new AcessoDados();
                conn.Sql = "select codigo as Codigo,nome as Nome,estoque as Estoque,valor as Valor from produto where nome Like '%" + nome.Trim() + "%'";
                tproduto = conn.selecionar();
            }catch(Exception e)
            {
                MessageBox.Show("Erro ao acessar Banco de dados: "+e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return tproduto;
        }

        public DataTable pesquisaProduto(int codigo)
        {
            DataTable tproduto = new DataTable();
            try
            {
                AcessoDados conn = new AcessoDados();
                conn.Sql = "select codigo as Codigo,nome as Nome,estoque as Estoque,valor as Valor from produto where codigo = " + Convert.ToInt32(codigo);
                tproduto = conn.selecionar();
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro ao acessar Banco de dados: " + e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return tproduto;
        }

        public DataTable UpdateGrid()
        {
            DataTable tproduto = new DataTable();
            try
            {
                AcessoDados conn = new AcessoDados();
                conn.Sql = "select codigo as Codigo,nome as Nome,estoque as Estoque,valor as Valor from produto order by nome";
                tproduto = conn.selecionar();
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro ao acessar Banco de dados: " + e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return tproduto;
        }

        public long Editar()
        {
            long id = new long();
            try
            {
                AcessoDados p = new AcessoDados();
                p.Sql = "update produto set nome ='" + this.Nome + "', valor = '" + this.Valor + "',estoque ='" + this.Estoque + "' where codigo = '" + this.Codigo + "'";
                id = p.UpdateSql();
                MessageBox.Show("Produto atualizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro ao acessar Banco de dados: " + e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return id;
        }
    }
}