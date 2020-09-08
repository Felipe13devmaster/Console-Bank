using System;
using ConsoleBank.Negocio;
using ConsoleBank.Funcionarios;
using ConsoleBank.Sistemas;

namespace ConsoleBank
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ContaCorrente contaCorrente = new ContaCorrente(117, 563002);
                ContaCorrente contaCorrente1 = new ContaCorrente(110, 223005);
                contaCorrente1.Transferir(10000, contaCorrente);
                contaCorrente.Depositar(50);
                Console.WriteLine(contaCorrente.Saldo);
                contaCorrente.Sacar(-500);
                
            }
            catch (ArgumentException e)
            {
                if (e.ParamName == "numero")
                {

                }

                Console.WriteLine("Ocorreu uma exceção do tipo ArgumentException");
                Console.WriteLine("Argumento com problema: " + e.ParamName);
                Console.WriteLine(e.Message);
            }
            catch (SaldoInsuficienteException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Exceção do tipo SaldoInsuficienteException.");
                Console.WriteLine(e.Saldo);
                Console.WriteLine(e.ValorSaque);
                Console.WriteLine(e.StackTrace);
            }
            Console.ReadLine();
        }

        public static void UsarSistema()
        {
            SistemaInterno sistemaInterno = new SistemaInterno();

            Diretor diretor = new Diretor("391.432.388-95");
            diretor.Nome = "Alfredo";
            diretor.Senha = "5218";

            GerenteDeConta gerenteDeConta = new GerenteDeConta("977.355.899-88");
            gerenteDeConta.Nome = "Gabriela";
            gerenteDeConta.Senha = "1234";

            ParceiroComercial parceiroComercial = new ParceiroComercial();
            parceiroComercial.Senha = "4321";

            sistemaInterno.Logar(diretor, "5218");
            sistemaInterno.Logar(gerenteDeConta, "1234");
            sistemaInterno.Logar(parceiroComercial, "4321");
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

            Console.WriteLine("Total de bonificação do mes: " + gerenciadorBonificacao.GetTotalBonificacao());
        }
    }
}
