/* Nivelamento.
Fazer um programa para ler o nome de um aluno e as três notas que ele obteve nos três trimestres do ano (primeiro trimestre vale 30 e o segundo e terceiro valem 35 cada). Ao final, mostrar qual a nota final do aluno no
ano. Dizer também se o aluno está APROVADO ou REPROVADO e, em caso negativo, quantos pontos faltam para o aluno obter o mínimo para ser aprovado (que é 60 pontos). Você deve criar uma classe Aluno para resolver este
problema.
 */
using System.Globalization;

namespace Exercicio03
{
    internal class Aluno
    {
        public string Nome;
        public double Nota1;
        public double Nota2;
        public double Nota3;

        public Aluno(string nome, double nota1, double nota2, double nota3)
        {
            Nome = nome;
            Nota1 = nota1;
            Nota2 = nota2;
            Nota3 = nota3;
        }

        public double NotaFinal()
        {
            return Nota1 + Nota2 + Nota3;
        }

        public override string ToString()
        {
            if (NotaFinal() >= 60.00)
            {
                return "SITUAÇÃO ATUAL DO ALUNO " 
                    + Nome
                    + ":"
                    +"\nNOTA FINAL = " 
                    + NotaFinal().ToString("F2", CultureInfo.InvariantCulture)
                    + "\nAPROVADO";
            } else
            {
                return "SITUAÇÃO ATUAL DO ALUNO "
                    + Nome
                    + ":"
                    + "\nNOTA FINAL = "
                    + NotaFinal().ToString("F2", CultureInfo.InvariantCulture)
                    + "\nREPROVADO"
                    + "\nFALTARAM "
                    + (60.00 - NotaFinal()).ToString("F2", CultureInfo.InvariantCulture)
                    + " PONTOS";
            }            
                
                
        }
    }
}
