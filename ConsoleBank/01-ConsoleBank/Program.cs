using System;
using ConsoleBank.Negocio;
using ConsoleBank.Funcionarios;


namespace ConsoleBank
{
    class Program
    {
        static void Main(string[] args)
        {
            CalcularBonificacao();

            Console.ReadLine();
        }

        public static void CalcularBonificacao()
        {
            GerenciadorBonificacao gerenciadorBonificacao = new GerenciadorBonificacao();

            Designer designer = new Designer("458.288.397-30");
            designer.Nome = "Fabio";

            Diretor diretor = new Diretor("391.432.388-95");
            diretor.Nome = "Alfredo";

            Auxiliar auxiliar = new Auxiliar("277.355.988-87");
            auxiliar.Nome = "Jose";

            GerenteDeConta gerenteDeConta = new GerenteDeConta("977.355.899-88");
            gerenteDeConta.Nome = "Gabriela";

            Desenvolvedor desenvolvedor = new Desenvolvedor("391.322.855-94");
            desenvolvedor.Nome = "Felipe";

            gerenciadorBonificacao.Registrar(designer);
            gerenciadorBonificacao.Registrar(diretor);
            gerenciadorBonificacao.Registrar(auxiliar);
            gerenciadorBonificacao.Registrar(gerenteDeConta);
            gerenciadorBonificacao.Registrar(desenvolvedor);

            Console.WriteLine("Total de boificação do mes: " + gerenciadorBonificacao.GetTotalBonificacao());
        }
    }
}
