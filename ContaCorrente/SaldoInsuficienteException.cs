using System;
using System.Collections.Generic;
using System.Text;

namespace ContaCorrente
{
    public class SaldoInsuficienteException : Exception
    {
        public SaldoInsuficienteException(string mensagem) : base(mensagem) //passei a diante a string mensagem para a minha classe base
        {
            
        }




    }
}
