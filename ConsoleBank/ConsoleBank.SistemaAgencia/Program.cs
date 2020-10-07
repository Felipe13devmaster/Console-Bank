using ConsoleBank.Modelos.Funcionarios;
using ConsoleBank.Modelos.Negocio;
using ConsoleBank.SistemaAgencia.Extensoes;
using Humanizer;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ConsoleBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            var enderecoDoArquivo = "C:/Users/felip/Desktop/ListadeContas.txt";

            using (var fluxoDoArquivo = new FileStream(enderecoDoArquivo, FileMode.Open))
            using (var leitor = new StreamReader(fluxoDoArquivo))
            {
                while (!leitor.EndOfStream)
                {
                    var linha = leitor.ReadLine();//Usar ReadToEnd() com cuidado pois ao contrario do buffer ele carrega tudo de uma vez.
                    var contaCorrente = ConverterStringParaContaCorrente(linha);
                    var mensagem = $"Conta numero: {contaCorrente.Numero} Agencia: {contaCorrente.Agencia} Saldo: {contaCorrente.Saldo} Titular: {contaCorrente.Titular.Nome}";
                    Console.WriteLine(mensagem);
                    //Console.WriteLine(linha);
                }
            }

            Console.ReadLine();
        }

        private static void LidandoComstreamDiretamente()
        {
            string enderecoDoArquivo = "C:/Users/felip/Desktop/ListadeContas.txt";

            using (var fluxoDoArquivo = new FileStream(enderecoDoArquivo, FileMode.Open))//Por baixo exeuta o Finally que executa o metoto Dispose() que por sua vez invova o Close()
            {
                var buffer = new byte[1024];// equivale a 1Kbyte.
                var numeroDeBytesLidos = -1;//Recebe -1 pois, o metodo FileStream.Read() sempre retorna positivo ou zero.Então essa e uma inicialização de variavel segura.

                while (numeroDeBytesLidos != 0)
                {
                    numeroDeBytesLidos = fluxoDoArquivo.Read(buffer, 0, 1024);//Read() retorna o numero de bytes lidos ,e retorna zero quando termina de ler.
                    EscreverBuffer(buffer, numeroDeBytesLidos);
                }
            }
        }

        private static void EscreverBuffer(byte[] buffer, int bytesLidos)
        {
            var utf8 = new UTF8Encoding();//Equivale a Enconding.UTF8;.
            var texto = utf8.GetString(buffer, 0, bytesLidos);

            Console.Write(texto);

            //foreach (var meuByte in buffer)
            //{
            //    Console.Write(meuByte);
            //    Console.Write(" ");
            //}
        }

        static ContaCorrente ConverterStringParaContaCorrente(string linha)
        {
            string[] campos = linha.Split(' ');// qubra string apartir do caractere separador definido np ctor.Retorna um array de strings.
            var agencia = campos[0];
            var numero = campos[1];
            var saldo = campos[2];
            var nomeTitular = campos[3];

            var agenciaInt = int.Parse(agencia);
            var numeroInt = int.Parse(numero);
            var saldoDouble = double.Parse(saldo.Replace('.', ','));

            var titular = new Cliente();
            titular.Nome = nomeTitular;

            var resultado = new ContaCorrente(agenciaInt, numeroInt);
            resultado.Depositar(saldoDouble);
            resultado.Titular = titular;

            return resultado;
        }

        private static void UsarListas()
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
