using Exercicio06;
using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Entre com o número da conta: ");
        int NumeroDaConta = int.Parse(Console.ReadLine());
        Console.Write("Entre com o titular da conta: ");
        string NomeDoTitular = Console.ReadLine();
        Console.Write("Havéra um depósito inicial? ");
        bool DepositoInicial = bool.Parse(Console.ReadLine());
        double ValorDepositoInicial;
        if (DepositoInicial == true) 
        {
            Console.Write("Entre com o valor de depósito inicial: ");
            ValorDepositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        } else
        {
            ValorDepositoInicial = 0.0;
        }
        
        ContaBancaria conta1 = new ContaBancaria(NumeroDaConta, NomeDoTitular, DepositoInicial, ValorDepositoInicial);
        Console.WriteLine(conta1);

        Console.WriteLine("Digite um valor para depósito: ");
        double ValorDeposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        conta1.Deposito(ValorDeposito);
        Console.WriteLine(conta1);

        Console.WriteLine("Digite um valor para saque: ");
        double ValorSaque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        conta1.Saque(ValorSaque);
        Console.WriteLine(conta1);

    }
}