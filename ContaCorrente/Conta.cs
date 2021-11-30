using System;
using System.Collections.Generic;
using System.Text;

namespace ContaCorrente
{
    public class Conta
    {

        public Cliente Titular { get; set; }

        
        public static int totalContascriadas { get; private set; }
        
        public static double taxaOperacao { get; private set;}
        private readonly int _agencia; //somente leitura readonly //aqui eu posso remover o setter e deixar somente o get sem expansao, para o compilador gerar o campo somente leitura
        public int Agencia
        {
            get
            {
                return _agencia;
            }
        }



        private readonly int _numero; //somente leitura
        public int Numero //essa variavel aqui é pra eu poder ler a variavel privada _numero
        {
            get
            {
                return _numero;
            }
        }



        public double taxaOpp { get; set; }
        private double _saldo = 100;

        public Conta(int numAgencia , int numConta)
        {
            if (numAgencia <= 0)
            {
                throw new ArgumentException("a agencia deve ser maior que 0", nameof(numAgencia));
            }
            if (numConta <= 0)
            {
                throw new ArgumentException("numero deve ser maior que 0",nameof(numConta));
            }

            _agencia = numAgencia;
            _numero = numConta;
            totalContascriadas++;
            taxaOperacao = 30 / totalContascriadas;
            
        }
        public double getTaxaOperacao()
        {
            taxaOpp = taxaOperacao;
            return taxaOpp;
        }

        public double Saldo
        {
            get
            {
                return _saldo;
            }
            set
            {
                if (value < 0)
                {
                    return;
                }

                _saldo = value;
            }
        }

        public bool Sacar(double valor)
        {
            if (valor < 0)
            {
                throw new ArgumentException("valor nao pode ser menor que 0");
            }
            if (_saldo < valor)
            {
                throw new SaldoInsuficienteException("Saldo insuficiente para o saque : "+valor);
            }

            _saldo -= valor;
            return true;
        }

        public void Depositar(double valor)
        {
            _saldo += valor;
        }


        public bool Transferir(double valor, Conta contaDestino)
        {
            if (_saldo < valor)
            {
                throw new SaldoInsuficienteException("Saldo insuficiente para a transferencia de : " + valor);
            }

            try
            {
                Sacar(valor);
            }
            catch (SaldoInsuficienteException e)
            {
                throw;
            }

            contaDestino.Depositar(valor);
            return true;
        }
    }
}
