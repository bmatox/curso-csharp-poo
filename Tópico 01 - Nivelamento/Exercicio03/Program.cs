using Exercicio03;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Nome do aluno: ");
        string nome = Console.ReadLine();
        Console.WriteLine("Digite as três notas do aluno:");
        double nota1 = double.Parse(Console.ReadLine());
        double nota2 = double.Parse(Console.ReadLine());
        double nota3 = double.Parse(Console.ReadLine());

        Aluno aluno1 = new Aluno(nome, nota1, nota2, nota3);
        Aluno aluno2 = new Aluno("Alex Green", 17.00, 20.00, 15.00);

        Console.WriteLine(aluno1);
        Console.WriteLine("");
        Console.WriteLine(aluno2);
    }
}