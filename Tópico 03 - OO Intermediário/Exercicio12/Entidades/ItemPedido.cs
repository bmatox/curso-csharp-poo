using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio12.Entidades
{
    internal class ItemPedido
    {
        public Produto Produto { get; set; }
        public int Quantidade { get; set; }
        public double Preco { get; set; }

        public ItemPedido()
        {

        }

        public ItemPedido(Produto produto, int quantidade, double preco)
        {
            Produto = produto;
            Quantidade = quantidade;
            Preco = preco;
        }

        public double subTotal()
        {
            return Quantidade * Preco;
        }

    }
}
