using ConsoleBank.Modelos.Funcionarios;
using ConsoleBank.Modelos.Negocio;
using Humanizer;
using System;

namespace ConsoleBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            string url = "https://www.consolebank.com.br/cambio?moedaOrigem=real&moedaDestino=dolar&valor=1500";

            Console.ReadLine();
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
