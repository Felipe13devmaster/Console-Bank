using System;

namespace ConsoleBank
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente gabriela = new Cliente();

            gabriela.nome = "Gabriela";
            gabriela.cpf = "391.422.894-40";
            gabriela.profissao = "Assistente Rub";

            ContaCorrente contadaGabriela = new ContaCorrente();

            contadaGabriela.titular = gabriela;
            contadaGabriela.agencia = 100;
            contadaGabriela.numero = 59017;

            contadaGabriela.Sacar(50);
            contadaGabriela.Depositar(450);

            Console.WriteLine("Titular: " + contadaGabriela.titular.nome);
            Console.WriteLine("Cpf: " + contadaGabriela.titular.cpf);
            Console.WriteLine("Profissão: " + contadaGabriela.titular.profissao);
            Console.WriteLine("Agencia: " + contadaGabriela.agencia);
            Console.WriteLine("Numero: " + contadaGabriela.numero);
            Console.WriteLine("Saldo: " + contadaGabriela.ConsultarSaldo());
            Console.WriteLine();

            ContaCorrente contadoFelipe = new ContaCorrente();

            contadoFelipe.agencia = 100;
            contadoFelipe.numero = 59018;
            
            contadoFelipe.Depositar(50);
            contadoFelipe.Transferir(40, contadaGabriela);

            Console.WriteLine("Titular: " + contadoFelipe.titular);
            Console.WriteLine("Agencia: " + contadoFelipe.agencia);
            Console.WriteLine("Numero: " + contadoFelipe.numero);
            Console.WriteLine("Saldo: " + contadoFelipe.ConsultarSaldo());
            Console.ReadLine();
        }
    }
}
