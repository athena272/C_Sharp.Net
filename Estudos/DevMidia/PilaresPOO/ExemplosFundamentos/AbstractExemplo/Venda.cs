using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ExemplosFundamentos.SealedClass;

namespace ExemplosFundamentos.AbstractExemplo
{
    public abstract class Venda
    {
        public DateTime DataVenda { get; set; }

        public String Vendedor { get; set; }

        public IList<Produto> Produtos { get; set; }

        public double CalcularValorLiquidoVenda()
        {
            double desconto = CalcularDescontoCliente();

            double valorTotalProdutos = CalcularTotalProdutos();

            return valorTotalProdutos - desconto;
        }

        public abstract double CalcularDescontoCliente();

        public double CalcularTotalProdutos()
        {
            double total = 0;

            foreach (Produto produto in Produtos)
            {
                total += produto.Valor;
            }

            return total;
        }
    }
}