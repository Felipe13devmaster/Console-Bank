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
            ProcessarURL();

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
