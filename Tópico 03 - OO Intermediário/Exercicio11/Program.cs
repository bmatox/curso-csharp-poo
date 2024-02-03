/* Exercício resolvido 01 (Composição e Enum) - Ler os dados de um trabalhador com N contratos (N fornecido pelo usuário). Depois, solicitar
do usuário um mês e mostrar qual foi o salário do funcionário nesse mês. */
using Exercicio11.Entidades;
using Exercicio11.Entidades.Enums;
using System.Globalization;
using System.Diagnostics.Contracts;
using System.Diagnostics.Metrics;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Entre com o nome do departamento: ");
        string name = Console.ReadLine();
        Departamento dep = new Departamento(name);

        Console.WriteLine("Entre com os dados do trabalhador: ");
        Console.Write("Nome: ");
        string name1 = Console.ReadLine();
        Console.Write("Nível (Junior/Pleno/Senior): ");
        string nivel = Console.ReadLine();
        NivelDoTrabalhador nt = Enum.Parse<NivelDoTrabalhador>(nivel);
        Console.Write("Salário base: ");
        double salariobase = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Trabalhador trabalhador = new Trabalhador(name1, nt, salariobase, dep);
        Console.Write("Quantos contratos para esse trabalhador? ");
        int numerocontratos = int.Parse(Console.ReadLine());
        for (int i = 0; i < numerocontratos; i++)
        {
            Console.WriteLine("Entre com os dados contrato #" + (i+1) + ":");
            Console.Write("Data (DD/MM/AAAA): ");
            string data = Console.ReadLine();
            string formato = "dd/MM/yyyy";
            IFormatProvider provedor = CultureInfo.InvariantCulture;
            DateTime data1 = DateTime.ParseExact(data, formato, provedor);
            Console.Write("Valor por hora: ");
            double vph = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Duração (horas): ");
            int duracao = int.Parse(Console.ReadLine());
            ContratoDeHora contratoDeHora = new ContratoDeHora(data1, vph, duracao);
            trabalhador.AdicionarContrato(contratoDeHora);
        }
        Console.Write("Entre com o mês e ano para calcular o ganho (MM/AAAA): ");
        string mesano = Console.ReadLine();

        // Separar a string em uma matriz de strings usando a barra como separador
        string[] partes = mesano.Split('/');

        // Converter cada parte da matriz em um inteiro usando o método int.Parse
        int mes1 = int.Parse(partes[0]); 
        int ano1 = int.Parse(partes[1]);
        double gh = trabalhador.Ganho(mes1, ano1);
        Console.WriteLine("Nome: " + name1);
        Console.WriteLine("Departamento: " + name);
        Console.WriteLine("Ganho para " + mesano + ": R$ " +  gh.ToString("F2", CultureInfo.InvariantCulture));
    }
}