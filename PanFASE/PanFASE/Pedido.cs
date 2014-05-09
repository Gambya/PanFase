using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PanFASE
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
