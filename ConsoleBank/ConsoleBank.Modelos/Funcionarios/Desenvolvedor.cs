namespace ConsoleBank.Modelos.Funcionarios
{
    public class Desenvolvedor : Funcionario
    {
        public Desenvolvedor(string cpf) : base(cpf, 3000)
        {

        }

        public override void AumentarSalario()
        {
            Salario *= 1.15;
        }

        internal protected override double GetBonificacao()
        {
            return Salario * 0.1;
        }
    }
}
