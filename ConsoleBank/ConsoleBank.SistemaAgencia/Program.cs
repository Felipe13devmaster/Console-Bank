using ConsoleBank.Modelos.Funcionarios;
using ConsoleBank.Modelos.Negocio;
using System;

namespace ConsoleBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaCorrente = new ContaCorrente(123, 550017);
            FuncionarioAutenticavel funcionario = null;
            Estagiario estagiario = new Estagiario(1234, 1000);
            

            Console.ReadLine();
        }
    }
}
