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
        // DADOS DO TRABALHADOR E INSTANCIAÇÃO

        Console.Write("Entre com o nome do departamento: ");
        string name = Console.ReadLine();
        Departamento dep = new Departamento(name);

        // DADOS DO TRABALHADOR E INSTANCIAÇÃO

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
            DateTime data1 = DateTime.Parse(Console.ReadLine());
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

        Console.WriteLine("Nome: " + trabalhador.Nome);
        Console.WriteLine("Departamento: " + trabalhador.Departamento.Name);
        Console.WriteLine("Ganho para " + mesano + ": R$ " + trabalhador.Ganho(mes1, ano1).ToString("F2", CultureInfo.InvariantCulture));
       
    }
}