using System.Globalization;
using Exercicio09;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Quantos funcionários serão registrados? ");
        int n = int.Parse(Console.ReadLine());

        List<Funcionario> list = new List<Funcionario>();
        
        // Adicionando cada objeto funcionário à lista. 
        for (int i = 0; i < n; i++)
        {
            Funcionario fun = new Funcionario(int.Parse(Console.ReadLine()), Console.ReadLine(), double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
            list.Add(fun);
        }
        
        // Imprimindo no console os valores de todos os blocos de funcionários.
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("\nFuncionário #" + (i+1));
            Console.WriteLine("ID: " + list[i].id);
            Console.WriteLine("Nome: " + list[i].nome);
            Console.WriteLine("Salário: R$ " + list[i].salario.ToString("F2", CultureInfo.InvariantCulture));
        }

        Console.Write("\nEntre com o ID do funcionário que terá acréscimo no salário: ");
        int idfuncionario = int.Parse(Console.ReadLine());

        bool encontrado = false; // Variável para indicar se o funcionário foi encontrado ou não
        for (int i = 0; i < n; i++)
        {
            if (list[i].id == idfuncionario)
            {
                Console.Write("Entre com a porcentagem: ");
                int porc = int.Parse(Console.ReadLine());
                list[i].AumentoDeSalario(porc);
                encontrado = true; // Marca a variável como verdadeira se o funcionário foi encontrado
                break; 
            }
        }
        if (!encontrado) // Se a variável for falsa, significa que o funcionário não foi encontrado
        {
            Console.WriteLine("Esse ID não existe na lista.");
        }

        // Imprimindo os atributos atualizados de cada funcionário
        Console.WriteLine("DADOS ATUALIZADOS DOS FUNCIONÁRIOS: ");
        for (int i = 0; i < list.Count; i++)
        {
            Console.WriteLine(list[i].ToString()); 
        }


    }
}