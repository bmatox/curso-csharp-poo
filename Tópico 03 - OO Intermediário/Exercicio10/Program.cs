// Enumeração e composição
using Exercicio10.Entidades;
using Exercicio10.Entidades.Enums;
internal class Program
{
    private static void Main(string[] args)
    {
        Pedido pedido = new Pedido(1080, 0);
        Console.WriteLine(pedido);

        // Convertendo um valor do tipo string para enum.

        StatusDoPedido sp = Enum.Parse<StatusDoPedido>("Entregue");
        Console.WriteLine(sp);
    }
}