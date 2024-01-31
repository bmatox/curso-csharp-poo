using Exercicio11.Entidades.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio11.Entidades
{
    internal class Trabalhador
    {
        public string Nome { get; set; }
        public NivelDoTrabalhador Nivel {  get; set; }
        public double SalarioBase { get; set; }

        public Departamento Departamento { get; set; }

        public List<ContratoDeHora> Contratos { get; set; }

    }
}
