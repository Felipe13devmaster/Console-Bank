using System;
using ConsoleBank.Negocio;
using ConsoleBank.Funcionarios;


namespace ConsoleBank
{
    class Program
    {
        static void Main(string[] args)
        {
            GerenciadorBonificacao gerenciadorBonificacao = new GerenciadorBonificacao();

            Funcionario carlos = new Funcionario();
            carlos.Nome = "Carlos";
            carlos.CPF = "397.288.559-76";
            carlos.Salario = 2000;
            gerenciadorBonificacao.Registrar(carlos);

            Diretor gabriela = new Diretor();
            gabriela.Nome = "Gabriela";
            gabriela.CPF = "185.277.355-85";
            gabriela.Salario = 10000;
            gerenciadorBonificacao.Registrar(gabriela);


            Console.WriteLine(carlos.GetBonificacao());
            Console.WriteLine(gabriela.GetBonificacao());
            Console.WriteLine(gerenciadorBonificacao.GetTotalBonificacao());

            Console.ReadLine();
        }
    }
}
