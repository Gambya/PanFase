﻿using PanFASE.com.merda.panfase.ADO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Collections;
using System.Windows.Forms;

namespace PanFASE
{
    public class PedidoProduto:Pedido
    {
        public int CodigoPedidoProduto { get; set; }
        public DateTime DtVenda { get; set; }
        public string Nome { get; set; }
        public double Quantidade { get; set; }
        public double ValorTotalProduto { get; set; }

        public void TirarPedido(List<PedidoProduto> produtos)
        {
            if (this.Clientes == null)
            {
                Cliente clientes = new Cliente();
                clientes.Codigo = 1;
                this.Clientes = clientes;
            }
            TConnect p = new TConnect();
            p.Sql = "insert into pedido(cod_cliente,cod_funcionario)values(" + this.Clientes.Codigo + "," + this.Funcionarios.Codigo + ")";
            long id = p.Inserir();

            for (int i = 0; i < produtos.Count(); i++)
            {
                TConnect pp = new TConnect();
                string dateTimeFormat = "{0}-{1}-{2} {3}:{4}:{5}";
                string dtvendas = string.Format(dateTimeFormat, this.DtVenda.Year, this.DtVenda.Month, this.DtVenda.Day, this.DtVenda.Hour, this.DtVenda.Minute, this.DtVenda.Second);
                pp.Sql = "insert into pedidoproduto(dtvenda,cod_produto,quantidade,valortotal,cod_pedido)values('" + dtvendas + "','" + produtos[i].CodigoPedidoProduto + "','" + produtos[i].Quantidade + "','" + produtos[i].ValorTotalProduto + "','" + id + "')";
                pp.Inserir();
                this.BaixaEstoque(produtos[i].Quantidade, produtos[i].CodigoPedidoProduto);
            }
        }

        private void BaixaEstoque(double qtd, int codigo)
        {
            TConnect p = new TConnect();
            p.Sql = "select estoque from produto where codigo = " + codigo;
            DataTable dt = p.selecionar();
            double estoque = Convert.ToDouble(dt.Rows[0]["estoque"]);
            estoque = estoque - qtd;
            TConnect u = new TConnect();
            u.Sql = "update produto set estoque ='" + estoque + "' where codigo = '" + codigo + "'";
            u.UpdateSql();
        }
        public bool VerificaEstoque(int codigo, double qtd)
        {
            TConnect p = new TConnect();
            p.Sql = "select estoque from produto where codigo = " + codigo;
            DataTable dt = p.selecionar();
            double estoque = Convert.ToDouble(dt.Rows[0]["estoque"]);
            if ((estoque-qtd) < 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
