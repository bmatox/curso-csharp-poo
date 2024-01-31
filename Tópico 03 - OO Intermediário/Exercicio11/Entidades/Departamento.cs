using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio11.Entidades
{
    internal class Departamento
    {
        public string Name { get; set; }

        public Departamento()
        {
            
        }
        public Departamento(string name)
        {
            Name = name;
        }
    }
}
