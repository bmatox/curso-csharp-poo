/*
A dona de um pensionato possui dez quartos para alugar para estudantes, sendo esses quartos identificados pelos números 0 a 9.
Quando um estudante deseja alugar um quarto, deve-se registrar o nome e e-mail deste estudante.

Fazer um programa que inicie com todos os dez quartos vazios, e depois leia uma quantidade N representando o número de estudantes 
que vão alugar quartos (N pode ser de 1 a 10). Em seguida, registre o aluguel dos N estudantes. Para cada registro de aluguel, 
informar o nome e e-mail do estudante, bem como qual dos quartos ele escolheu (de 0 a 9). Suponha que seja escolhido um quarto vago. Ao final, seu programa deve imprimir
um relatório de todas ocupações do pensionato, por ordem de quarto, conforme exemplo.
*/

namespace Exercicio07
{
    internal class Pensionato
    {
        public int NumerodoQuarto { get; set; }
        public string NomeDoEstudante { get; set; }
        public string EmailDoEstudante { get; set; }

        public Pensionato(int numerodoQuarto, string nomeDoEstudante, string emailDoEstudante)
        {
            NumerodoQuarto = numerodoQuarto;
            NomeDoEstudante = nomeDoEstudante;
            EmailDoEstudante = emailDoEstudante;
        }
    }
}
