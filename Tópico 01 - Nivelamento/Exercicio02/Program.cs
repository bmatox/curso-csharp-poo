using Exercicio02;

internal class Program
{
    private static void Main(string[] args)
    {
        Produto produto = new Produto("TV", 900.00, 10);
        produto.MostraDadosDoProduto();
        produto.AdicionarProdutos(5);
        Console.WriteLine(produto.ToString());
        produto.RemoverProdutos(3);
        Console.WriteLine(produto.ToString());
    }
}