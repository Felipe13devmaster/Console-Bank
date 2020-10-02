using ConsoleBank.Modelos.Funcionarios;
using ConsoleBank.Modelos.Negocio;
using ConsoleBank.SistemaAgencia.Extensoes;
using Humanizer;
using System;
using System.Collections.Generic;

namespace ConsoleBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> idades = new List<int>();
            idades.Add(12);
            idades.Add(15);

            idades.AdicionarVarios(1, 2, 3, 4);

            idades.Remove(3);

            for (int i = 0; i < idades.Count; i++)
            {
                Console.WriteLine(idades[i]);
            }



            Console.ReadLine();
        }

        private static void ProcessarURL()
        {
            string url = "https://www.consolebank.com.br/cambio?moedaOrigem=real&moedaDestino=dolar&valor=1500";

            ExtratorValorDeArgumentosURL extrator = new ExtratorValorDeArgumentosURL(url);
            string moedaOrigem = extrator.GetValor("moedaOrigem");
            string moedaDestino = extrator.GetValor("moedaDestino");
            string valor = extrator.GetValor("Valor");
            Console.WriteLine("Moeda origem: " + moedaOrigem);
            Console.WriteLine("Moeda destino: " + moedaDestino);
            Console.WriteLine("Valor: " + valor);
        }

        private static void CalcularPrazoVencimento()
        {
            DateTime vencimento = new DateTime(2020, 09, 25);
            DateTime dataCorrente = DateTime.Now;
            TimeSpan diferenca = vencimento - dataCorrente;

            string mensagem = "Vencimento em " + TimeSpanHumanizeExtensions.Humanize(diferenca);
            Console.WriteLine(mensagem);
        }
    }
}
