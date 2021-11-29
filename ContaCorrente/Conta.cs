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
        public int Agencia { get; set; }
        public int Numero { get; set; }

        public double taxaOpp { get; set; }
        private double _saldo = 100;

        public Conta(int agencia , int numero)
        {
            this.Agencia = agencia;
            this.Numero = numero;
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
