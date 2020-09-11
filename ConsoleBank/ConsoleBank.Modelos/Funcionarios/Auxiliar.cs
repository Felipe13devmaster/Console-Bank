namespace ConsoleBank.Modelos.Funcionarios
{
    public class Auxiliar : Funcionario
    {
        public Auxiliar(string cpf) : base(cpf, 1500)
        {

        }

        public override void AumentarSalario()
        {
            Salario *= 1.1;
        }

        internal protected override double GetBonificacao()
        {
            return Salario * 0.2;
        }
    }
}
