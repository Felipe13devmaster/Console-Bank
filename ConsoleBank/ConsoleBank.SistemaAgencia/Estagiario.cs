using ConsoleBank.Modelos.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBank.SistemaAgencia
{
    public class Estagiario : Funcionario
    {
        public Estagiario(string cpf, double salario)
            : base(cpf, salario)
        {

        }
        public override void AumentarSalario()
        {
            //Implementação
        }

        protected override double GetBonificacao()
        {
            return Salario * 0.01;
        }
    }
}
