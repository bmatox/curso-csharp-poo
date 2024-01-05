// OO Básico - Aula sobre auto properties.
using System.Globalization;

namespace Exercicio05
{
    internal class Produto
    {
        private string _nome; // é uma boa prática manter o atributo privado em minúsculo e, além disso, incializá-lo com o "_".
        public double Preco { get; private set; } // propertie sendo usada para simplificar o código, privado no set porque ele nao deve alterar o atributo preço na classe principal. 
        public double Quantidade { get; private set; }
       
        public Produto(string nome, double preco, int quantidade)
        {
            _nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }
        public string Nome // propertie comum com get e set determinados no corpo da implementação.
        {
            get { return _nome; }
            set // como existe uma regra que determina a alteração do nome, o atributo continua sendo usado como private e é usada a propertie comum. 
            {
                if (value != null && value.Length > 1)
                {
                    _nome = value;
                }
            }
        }

        public double ValorTotalEmEstoque
        {
            get { return Preco * Quantidade; }
        }
        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade;
        }
        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;
        }
        public override string ToString()
        {
            return _nome
            + ", $ "
            + Preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + Quantidade
            + " unidades, Total: $ "
            + ValorTotalEmEstoque.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
