using Exercicio02;

internal class Program
{
    private static void Main(string[] args)
    {
        Produto produto = new Produto("TV", 900.00, 10);
        produto.MostraDadosDoProduto();
        produto.AdicionarProdutos(5);
        produto.MostraDadosDoProduto();
        produto.RemoverProdutos(3);
        produto.MostraDadosDoProduto();
    }
}