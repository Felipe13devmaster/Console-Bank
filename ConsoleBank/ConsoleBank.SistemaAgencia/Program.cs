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

            Console.ReadLine();
        }
    }
}
