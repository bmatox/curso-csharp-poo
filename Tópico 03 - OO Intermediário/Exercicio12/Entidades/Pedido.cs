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

        public Pedido(DateTime horadoPedido, StatusDoPedido statusPedido, List<ItemPedido> itens, Cliente cliente)
        {
            HoradoPedido = horadoPedido;
            StatusPedido = statusPedido;
            Itens = itens;
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
    }
}
