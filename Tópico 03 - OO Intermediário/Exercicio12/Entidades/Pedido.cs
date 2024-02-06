using System;
using Exercicio12.Entidades.Enums; // precisou adicionar para buscar o atributo do tipo enum (Status Pedido), que estava dentro de outro namespace.

namespace Exercicio12.Entidades
{
    internal class Pedido
    {
        public DateTime HoradoPedido { get; set; }
        public StatusDoPedido StatusPedido { get; set; }
        public List<ItemPedido> Itens { get; set; }
        public Cliente Cliente { get; set; }

        public Pedido()
        {
            
        }

        public Pedido(StatusDoPedido statusPedido, Cliente cliente)
        {
            HoradoPedido = DateTime.Now;
            StatusPedido = statusPedido;
            Cliente = cliente;
        }

        public void AddItem(ItemPedido itempedido)
        {
            Itens.Add(itempedido);
        }

        public void RemoveItem(ItemPedido itempedido)
        {
            Itens.Remove(itempedido);
        }

        public double Total()
        {
            double somatotal = 0.0;
            foreach (ItemPedido itens in Itens)
            {
                somatotal += itens.subTotal();
            }
            return somatotal;
        }
    }
}
