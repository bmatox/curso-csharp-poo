using Exercicio04;
using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Entre o valor do raio: ");
        double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        double circ = Calculadora.Circunferencia(raio); // não é preciso instanciar um objeto, pois o método estático pertence a própria classe e não a um objeto. Sendo assim, é possível chamar o método digitando o próprio nome da classe seguindo pelo nome do método.
        double volume = Calculadora.Volume(raio);
        Console.WriteLine("Circunferência: " + circ.ToString("F2", CultureInfo.InvariantCulture));
        Console.WriteLine("Volume: " + volume.ToString("F2", CultureInfo.InvariantCulture));
        Console.WriteLine("Valor de PI: " + Calculadora.Pi.ToString("F2",
        CultureInfo.InvariantCulture));
    }
}