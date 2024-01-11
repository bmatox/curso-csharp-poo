// Familiarização com a estrutura (classe) lista em c#

using System.Collections.Generic;
internal class Program
{
    private static void Main(string[] args)
    {
        List<string> list = new List<string>();

        list.Add("Bruno");
        list.Add("Amanda");
        list.Add("Nélio");
        list.Add("Ana");
        list.Insert(2, "Marco");
        Console.WriteLine("\nA lista tem " + list.Count + " elementos.");
        Console.WriteLine("");
        
        foreach (string nome in list)
        {
            Console.WriteLine(nome);
        }

        string s = list.Find(x => x[0] == 'A');
        int a = list.FindIndex(x => x[0] ==  'A');
        int b = list.FindLastIndex(x => x[0] == 'A');

        // Filtrar a lista com base em um predicado

        List<string> resultadodofiltro = list.FindAll(x => x.Length == 5); // Aqui se criou uma nova lista resultado para armazenar o resultado do filtro.


        Console.WriteLine("\nPrimeiro nome na lista que começa com a letra A: " + s);
        Console.WriteLine("\nPrimeira posição de quem começa com A: " + a);
        Console.WriteLine("\nÚltima posição de quem começa com A: " + b);

        Console.WriteLine("\nNomes que têm cinco caracteres: ");
        Console.WriteLine("");

        foreach (string nome in resultadodofiltro)
        {
            Console.WriteLine(nome);
        }

        // Remoção de nomes que obedeçam uma condição específica (predicado)

        list.RemoveAll(x => x[0] == 'A');

        Console.WriteLine("\nNomes que não iniciam com a letra A: ");
        Console.WriteLine("");
        foreach (string nome in list)
        {
            Console.WriteLine(nome);
        }

        // Remover elementos de um intervalo específico

        list.RemoveRange(0, 2);

        Console.WriteLine("\nNomes restantes após remoção dos elementos de índices 0 e 1: ");
        Console.WriteLine("");
        foreach (string nome in list)
        {
            Console.WriteLine(nome);
        }



    }
}