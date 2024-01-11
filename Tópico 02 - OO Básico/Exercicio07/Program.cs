using Exercicio07;

internal class Program
{
    private static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        Pensionato[] pensionato = new Pensionato[n];
        
        for (int i = 0; i < n; i++)
        {   
            int numero = int.Parse(Console.ReadLine());
            string nome = Console.ReadLine();
            string email = Console.ReadLine();
            pensionato[i] = new Pensionato(numero, nome, email);
        }

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("\nAluguel #" + (i+1));
            Console.WriteLine("Nome: " + pensionato[i].NomeDoEstudante);
            Console.WriteLine("Email: " + pensionato[i].EmailDoEstudante);
            Console.WriteLine("Quarto: " + pensionato[i].NumerodoQuarto);
        }

        Console.WriteLine("\nQuartos ocupados:");
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(pensionato[i].NumerodoQuarto + ": " + pensionato[i].NomeDoEstudante + ", " + pensionato[i].EmailDoEstudante);
        }        

    }
}