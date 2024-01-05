﻿/*
Em um banco, para se cadastrar uma conta bancária, é necessário informar o número da conta, o nome do
titular da conta, e o valor de depósito inicial que o titular depositou ao abrir a conta. Este valor de depósito
inicial, entretanto, é opcional, ou seja: se o titular não tiver dinheiro a depositar no momento de abrir sua
conta, o depósito inicial não será feito e o saldo inicial da conta será, naturalmente, zero.
Importante: uma vez que uma conta bancária foi aberta, o número da conta nunca poderá ser alterado. Já
o nome do titular pode ser alterado (pois uma pessoa pode mudar de nome por ocasião de casamento, por
exemplo).
Por fim, o saldo da conta não pode ser alterado livremente. É preciso haver um mecanismo para proteger
isso. O saldo só aumenta por meio de depósitos, e só diminui por meio de saques. Para cada saque
realizado, o banco cobra uma taxa de $ 5.00. Nota: a conta pode ficar com saldo negativo se o saldo não for
suficiente para realizar o saque e/ou pagar a taxa.
Você deve fazer um programa que realize o cadastro de uma conta, dando opção para que seja ou não
informado o valor de depósito inicial. Em seguida, realizar um depósito e depois um saque, sempre
mostrando os dados da conta após cada operação.
*/

using System.Globalization;

namespace Exercicio06
{
    internal class ContaBancaria
    {
        public int NumeroContaBancaria { get; private set; }
        public string NomedoTitular { get; set; }
        public bool DepositoInicial { get; private set; }
        public double ValorDepositoInicial;
        private double _saldo;

        public ContaBancaria(int numeroContaBancaria, string nomedoTitular, bool depositoInicial, double valorDepositoInicial)
        {
            NumeroContaBancaria = numeroContaBancaria;
            NomedoTitular = nomedoTitular;
            DepositoInicial = depositoInicial;
            ValorDepositoInicial = valorDepositoInicial;

            // Inicializando o saldo com o valor do depósito inicial, se houver
            if (DepositoInicial == true)
            {
                _saldo = ValorDepositoInicial;
            }
            else
            {
                _saldo = 0.0;
            }
        }

        public double Saldo
        {
            get { return _saldo; }
            set
            {
                // Atribuindo o valor do saldo sem alterar o valor do depósito inicial. Esse valor do value é recebido diretamente na classe principal (mesma ideia de receber um parâmetro do Java).
                _saldo = value;
            }
        }

        public void Deposito(double ValorD)
        {
            _saldo += ValorD;
        }
        
        public void Saque(double ValorS) 
        {
            _saldo -= (ValorS + 5);

        }

        public override string ToString()
        {
            return "Dados da conta atualizados:" 
                + "\nConta: " + NumeroContaBancaria 
                + ", Titular: " 
                + NomedoTitular 
                + ", Saldo: R$ " 
                + _saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
