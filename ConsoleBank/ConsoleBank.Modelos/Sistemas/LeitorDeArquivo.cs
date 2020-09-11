﻿using System;
using System.IO;

namespace ConsoleBank.Modelos.Sistemas
{
    public class LeitorDeArquivo : IDisposable
    {
        public string Arquivo { get; }

        public LeitorDeArquivo(string arquivo)
        {
            Arquivo = arquivo;
            //throw new FileNotFoundException();
            Console.WriteLine("Abrindo arquivo " + arquivo);
        }

        public string LerProximaLinha()
        {
            Console.WriteLine("Lendo linha...");
            //throw new IOException();
            return "Linha do arquivo";
        }

        public void Dispose()//Este e o metodo da interface Idisposable que tem a responsabilidade de liberar os recursos.
        {
            Console.WriteLine("Fechando arquivo.");
        }
    }
}