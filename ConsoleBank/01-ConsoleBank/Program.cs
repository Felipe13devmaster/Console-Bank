using System;

namespace ConsoleBank
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente gabriela = new Cliente();

            gabriela.Nome = "Gabriela";
            gabriela.Cpf = "391.422.894-40";
            gabriela.Profissao = "Assistente Rub";

            ContaCorrente contadaGabriela = new ContaCorrente();

            contadaGabriela.Titular = gabriela;
            contadaGabriela.Agencia = 100;
            contadaGabriela.Numero = 59017;

            contadaGabriela.Sacar(50);
            contadaGabriela.Depositar(450);

            Console.WriteLine("Titular: " + contadaGabriela.Titular.Nome);
            Console.WriteLine("Cpf: " + contadaGabriela.Titular.Cpf);
            Console.WriteLine("Profissão: " + contadaGabriela.Titular.Profissao);
            Console.WriteLine("Agencia: " + contadaGabriela.Agencia);
            Console.WriteLine("Numero: " + contadaGabriela.Numero);
            Console.WriteLine("Saldo: " + contadaGabriela.ConsultarSaldo());
            Console.WriteLine();

            ContaCorrente contadoFelipe = new ContaCorrente();

            contadoFelipe.Agencia = 100;
            contadoFelipe.Numero = 59018;
            
            contadoFelipe.Depositar(50);
            contadoFelipe.Transferir(40, contadaGabriela);

            Console.WriteLine("Titular: " + contadoFelipe.Titular);
            Console.WriteLine("Agencia: " + contadoFelipe.Agencia);
            Console.WriteLine("Numero: " + contadoFelipe.Numero);
            Console.WriteLine("Saldo: " + contadoFelipe.ConsultarSaldo());
            Console.ReadLine();
        }
    }
}
