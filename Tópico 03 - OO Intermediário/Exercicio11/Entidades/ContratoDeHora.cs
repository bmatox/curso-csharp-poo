namespace Exercicio11.Entidades
{
    internal class ContratoDeHora
    {
        public DateTime Data { get; set; }
        public double ValorPorHora { get; set; }
        public int Horas { get; set; }

        public ContratoDeHora()
        {
            
        }

        public ContratoDeHora(DateTime date, double valorPorHora, int horas)
        {
            Data = date;
            ValorPorHora = valorPorHora;
            Horas = horas;
        }

        public double ValorTotal()
        {
            return ValorPorHora * Horas;
        }
    }
}
