using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio11.Entidades
{
    internal class ContratoDeHora
    {
        public DateTime Date { get; set; }
        public double ValorPorHora { get; set; }
        public int Horas { get; set; }

        public ContratoDeHora()
        {
            
        }

        public ContratoDeHora(DateTime date, double valorPorHora, int horas)
        {
            Date = date;
            ValorPorHora = valorPorHora;
            Horas = horas;
        }

        public double TotalValue()
        {
            return this.ValorPorHora * this.Horas;
        }
    }
}
