using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio12.Entidades
{
    internal class Cliente
    {
        public double Nome { get; set; }
        public string Email { get; set; }
        public DateTime DataAniversario { get; set; }

        public Cliente()
        {
            
        }

        public Cliente(double nome, string email, DateTime dataAniversario)
        {
            Nome = nome;
            Email = email;
            DataAniversario = dataAniversario;
        }

    }
}
