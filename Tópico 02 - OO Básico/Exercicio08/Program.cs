using System.Collections.Generic;
internal class Program
{
    private static void Main(string[] args)
    {
        List<string> list = new List<string>();

        list.Add("Bruno");
        list.Add("Bob");
        list.Add("Ana");
        list.Add("Nélio");


        foreach (string nome in list)
        {
            Console.WriteLine(nome);
        }
    }
}