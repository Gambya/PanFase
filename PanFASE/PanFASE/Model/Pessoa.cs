using System.Data;


namespace PanFase
{
    public abstract class Pessoa
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }

        public abstract long Cadastrar();
        public abstract DataTable Pesquisar(string nome);
        public abstract DataTable Pesquisar(long cpf);
        public abstract DataTable UpdateGrid();
        public abstract long Editar();
    }

}