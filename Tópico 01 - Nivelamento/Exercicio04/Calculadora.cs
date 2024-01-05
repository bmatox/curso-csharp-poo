// Nivelamento - à partir do capítulo de classes, atributos, métodos, membros estáticos.
/*Fazer um programa para ler um valor numérico qualquer, e daí mostrar
quanto seria o valor de uma circunferência e do volume de uma esfera
para um raio daquele valor. Informar também o valor de PI com duas
casas decimais.*/

namespace Exercicio04
{
    internal class Calculadora
    {
        public static double Pi = 3.14; // o static indica que tanto esse atributo quanto os métodos são membros estáticos. Um membro estático é um membro que pertence à própria classe, em vez de a um objeto específico da classe.
        public static double Circunferencia(double r)
        {
            return 2.0 * Pi * r;
        }
        public static double Volume(double r)
        {
            return 4.0 / 3.0 * Pi * Math.Pow(r, 3);
        }
    }
}
