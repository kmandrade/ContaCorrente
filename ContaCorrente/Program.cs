using System;
using System.IO;

namespace ContaCorrente
{
    class Program
    {
        static void Main(string[] args)
        {
            CarregarContas();

            


            Console.ReadLine();
        }

        private static void CarregarContas()
        {
            LeitorDeArquivos leitor = new LeitorDeArquivos("contas.txt");
            try
            {
                
                leitor.LerProximaLinha();
                leitor.LerProximaLinha();
                leitor.LerProximaLinha();
                
            }
            catch (IOException)
            {
                Console.WriteLine("Execção do tipo IO");
            }
            finally
            {
                leitor.Fechar();
            }
            
        }
        public static void TestaException()
        {
            try
            {
                Conta conta = new Conta(13, 1234);
                Conta conta2 = new Conta(14, 2345);
                conta.Depositar(50);
                Console.WriteLine(conta.Saldo);

                conta.Transferir(500, conta2);

            }
            catch (ArgumentException e)
            {
                Console.WriteLine("Argumento com problema: ", e.ParamName);
                Console.WriteLine(e.Message);
            }
            catch (SaldoInsuficienteException e)
            {

                Console.WriteLine(e.Message);
            }


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
