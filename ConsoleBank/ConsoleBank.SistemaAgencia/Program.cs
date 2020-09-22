using ConsoleBank.Modelos.Funcionarios;
using ConsoleBank.Modelos.Negocio;
using System;

namespace ConsoleBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {

            ContaCorrente contaCorrente = new ContaCorrente(123, 55567);
            contaCorrente.Depositar(50);
            contaCorrente.Sacar(60);
            
            Console.WriteLine(contaCorrente.Saldo);

            Console.ReadLine();
        }
    }
}
