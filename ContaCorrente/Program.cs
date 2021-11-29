using System;

namespace ContaCorrente
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta conta = new Conta(123, 1234);
            Console.WriteLine(conta.taxaOpp);

            Console.ReadLine();
        }
    }
}
