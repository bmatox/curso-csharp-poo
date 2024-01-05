using Exercicio01;

internal class Program
{
    private static void Main(string[] args)
    {
        Triangulo x = new Triangulo(3.00, 4.00, 5.00);
        Triangulo y = new Triangulo(7.5, 4.5, 4.02);

        x.Area();
        y.Area();

        x.MaiorArea(x, y);
    }
}