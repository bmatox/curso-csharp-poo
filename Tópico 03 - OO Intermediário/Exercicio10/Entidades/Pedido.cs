using System;
using Exercicio10.Entidades.Enums; // precisou adicionar para buscar o atributo do tipo enum, que estava dentro de outro namespace.

namespace Exercicio10.Entidades
{
    internal class Pedido
    {
        public int Id { get; set; }
        public DateTime Moment { get; set; }
        public StatusDoPedido Status { get; set; }

        public override string ToString()
        {
            return Id
                + ", "
                + Moment
                + ", "
                + Status;
        }

    }
}
