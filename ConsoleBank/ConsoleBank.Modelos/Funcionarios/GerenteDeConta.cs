namespace ConsoleBank.Modelos.Funcionarios
{
    public class GerenteDeConta : FuncionarioAutenticavel
    {
        public GerenteDeConta(string cpf) : base(cpf, 4000)
        {

        }

        public override void AumentarSalario()
        {
            Salario *= 1.05;
        }

        internal protected override double GetBonificacao()
        {
            return Salario * 0.25;
        }
    }
}
