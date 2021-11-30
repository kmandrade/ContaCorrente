using System;

namespace ContaCorrente
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Conta conta = new Conta(0, 0);
                
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }

            




            Console.ReadLine();
        }

        
        public static void Dividir(int numero, int divisor)
        {
            
            try
            {
                int soma = numero / divisor;
                Console.WriteLine("o resultado da visisao é:" + soma);
            }
            catch (Exception erro)
            {
                Console.WriteLine(erro.Message);
                Console.WriteLine("nao é possivel fazer uma divisao por 0");
            }
            
            
        }
    }
}
