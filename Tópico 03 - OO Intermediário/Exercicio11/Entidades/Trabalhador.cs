using Exercicio11.Entidades.Enums;

namespace Exercicio11.Entidades
{
    internal class Trabalhador
    {
        public string Nome { get; set; }
        public NivelDoTrabalhador Nivel {  get; set; }
        public double SalarioBase { get; set; }

        // propriedade nao veio explícita. Foi percebida a necessidade de criar uma composição (situação em que os objetos estão associados entre si).
        public Departamento Departamento { get; set; }

        // composição do tipo lista de Contratos, pois um trabalhador tem vários contratos, assim como está explicitado no diagrama UML.
        public List<ContratoDeHora> Contratos { get; set; } = new List<ContratoDeHora>(); // instanciou de cara uma lista para garantir que a lista seja iniciada sempre. Com valor nulo. 

        public Trabalhador()
        {
            
        }
        
        public Trabalhador(string nome, NivelDoTrabalhador nivel, double salarioBase, Departamento departamento) // não é uma boa prática adicionar uma lista como parâmetro de um construtor, tendo em vista que é uma lista que vai tendo objetos adicionados ao passo em que houver demanda.
        {
            Nome = nome;
            Nivel = nivel;
            SalarioBase = salarioBase;
            Departamento = departamento;
        }

        public void AdicionarContrato(ContratoDeHora contrato)
        {
            Contratos.Add(contrato);
        }

        public void RemoverContrato(ContratoDeHora contrato)
        {
            Contratos.Remove(contrato);
        }

        public double Ganho(int ano, int mes)
        {
            double soma = SalarioBase;
            foreach (ContratoDeHora contratoDeHora in Contratos)
            {
                if (contratoDeHora.Data.Year == ano && contratoDeHora.Data.Month == mes)
                {
                    soma += contratoDeHora.ValorTotal();
                }
            }
            return soma;
        }

        /*
        public double Ganho(int ano, int mes)
        {
            double soma = SalarioBase;
            for (int i = 0; i < Contratos.Count; i++)
            {
                if (Contratos[i].Data.Year == ano && Contratos[i].Data.Month == mes)
                {
                    soma += Contratos[i].ValorTotal();
                }
            }
            return soma;
        }
        */
    }
}
