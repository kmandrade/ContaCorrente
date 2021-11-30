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
        private readonly int _agencia;
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

        public Conta(int agencia , int numero)
        {
            if (agencia <= 0)
            {
                throw new ArgumentException("a agencia deve ser maior que 0");
            }
            if (numero <= 0)
            {
                throw new ArgumentException("numero deve ser maior que 0");
            }

            _agencia = agencia;
            _numero = numero;
            taxaOperacao = 30 / totalContascriadas;
            totalContascriadas++;
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
            if (_saldo < valor)
            {
                return false;
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
                return false;
            }

            _saldo -= valor;
            contaDestino.Depositar(valor);
            return true;
        }
    }
}
