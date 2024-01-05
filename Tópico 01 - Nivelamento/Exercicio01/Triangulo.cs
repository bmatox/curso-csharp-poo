// Nivelamento - à partir do capítulo de classes, atributos, métodos, membros estáticos.
using System.Globalization;

namespace Exercicio01
{
    internal class Triangulo
    {
        public double A;
        public double B;
        public double C;
        public Triangulo(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;

        }
        public double Area()
        {
            double p = (A + B + C) / 2.0;
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }

        public void MaiorArea(Triangulo x, Triangulo y)
        {
            double areaX = x.Area();
            double areaY = y.Area();

            Console.WriteLine("Area de x = " + areaX.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Area de y = " + areaY.ToString("F4", CultureInfo.InvariantCulture));

            if (areaX > areaY)
            {
                Console.WriteLine("Maior area: X");
            }
            else
            {
                Console.WriteLine("Maior area: Y");
            }
        }
    }
}
