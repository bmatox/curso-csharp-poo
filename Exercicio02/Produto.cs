
using System.Globalization;

namespace Exercicio02
{
    internal class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public Produto(string Nome, double Preco, int Quantidade)
        {
            this.Nome = Nome;
            this.Preco = Preco;
            this.Quantidade = Quantidade;
        }

        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }

        public void AdicionarProdutos(int Quantidade)
        {
            this.Quantidade += Quantidade;
        }

        public void RemoverProdutos(int Quantidade)
        {
            this.Quantidade -= Quantidade;
        }

        public void MostraDadosDoProduto()
        {
            Console.WriteLine("Dados atualizados do produto: " + Nome + ", R$ " + Preco.ToString("F2", CultureInfo.InvariantCulture) + ", " + Quantidade + " unidades" + ", " + "Total: " + "R$ " + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
