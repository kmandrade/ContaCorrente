using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
namespace ContaCorrente
{
   public class LeitorDeArquivos
    {
        public string Arquivo { get; }

        public LeitorDeArquivos(string arquivo)
        {
            Arquivo = arquivo;
            Console.WriteLine("abrindo arquivo : " + arquivo);


        }

        public string LerProximaLinha()
        {
            Console.WriteLine("Lendo Linha ....");
            throw new IOException();
            return "linha do arquivo";
        }
        public void Fechar()
        {
            Console.WriteLine("fechando arquivo");
        }

    }
}
