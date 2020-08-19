using ConsoleBank.Sistemas;
using System.Runtime.Remoting.Metadata.W3cXsd2001;

namespace ConsoleBank.Funcionarios
{
    public class Diretor : Autenticavel
    {
        public Diretor(string cpf) : base(cpf, 5000)
        {

        }

        public override void AumentarSalario()
        {
            Salario *= 1.15;
        }

        public override double GetBonificacao()
        {
            return Salario * 0.5;
        }
    }
}
