﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio12.Entidades
{
    internal class Produto
    {
        public string Nome { get; set; }
        public double Preco { get; set; }

        public Produto()
        {
            
        }

        public Produto(string nome, double preco)
        {
            this.Nome = nome;
            this.Preco = preco;
        }
    }
}
