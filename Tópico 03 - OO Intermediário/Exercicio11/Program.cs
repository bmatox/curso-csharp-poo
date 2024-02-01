/* Exercício resolvido 01 (Composição e Enum) - Ler os dados de um trabalhador com N contratos (N fornecido pelo usuário). Depois, solicitar
do usuário um mês e mostrar qual foi o salário do funcionário nesse mês. */
using Exercicio11.Entidades;
using System.Diagnostics.Contracts;
using System.Diagnostics.Metrics;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Enter department's name: ");
        string name = Console.ReadLine();
        Departamento departamento = new Departamento(name);

        Console.WriteLine("Enter worker data: ");
        Console.WriteLine("Name: ");
        string name1 = Console.ReadLine();
        Console.WriteLine("Level(Junior / MidLevel / Senior): ");
     
    }
}