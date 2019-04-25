using PanFase.Data;
using System;
using System.Collections.Generic;
using System.Data;

namespace PanFase
{
    class RPedidoProduto
    {
        public List<PedidoProduto> GetPedidos(string inicio, string fim)
        {
            AcessoDados conn = new AcessoDados();
            conn.Sql = "select p.codigo,p.cod_cliente,p.cod_funcionario,pp.codigo,pp.dtvenda,pr.nome,pp.quantidade,pp.valortotal from pedido p, pedidoproduto pp, produto pr where p.codigo = pp.cod_pedido and pp.cod_produto = pr.codigo and pp.dtvenda BETWEEN '"+inicio+"' and '"+fim+"'";
            DataTable p = conn.selecionar();

            List<PedidoProduto> lista = new List<PedidoProduto>();
            for(int i = 0; i < p.Rows.Count; i++)
            {
                PedidoProduto pedido = new PedidoProduto();
	            pedido.Codigo = Convert.ToInt32(p.Rows[i][0]);
                pedido.DtVenda = Convert.ToDateTime(p.Rows[i][4]);
                pedido.Clientes.Codigo = Convert.ToInt32(p.Rows[i][1]);
                pedido.Funcionarios.Codigo = Convert.ToInt32(p.Rows[i][2]);
                pedido.CodigoPedidoProduto = Convert.ToInt32(p.Rows[i][3]);
                pedido.Nome = Convert.ToString(p.Rows[i][5]);
                pedido.Quantidade = Convert.ToDouble(p.Rows[i][6]);
                pedido.ValorTotalProduto = Convert.ToDouble(p.Rows[i][7]);

                lista.Add(pedido);
            }

            return lista;
        }
    }
}
