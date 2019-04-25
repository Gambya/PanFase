namespace PanFase
{
    abstract public class Pedido
    {
        public int Codigo { get; set; }
        public Cliente Clientes { get; set; }
        public Funcionario Funcionarios { get; set; }
        public Pedido()
        {
            this.Clientes = new Cliente();
            this.Funcionarios = new Funcionario();
        }
    }
}
