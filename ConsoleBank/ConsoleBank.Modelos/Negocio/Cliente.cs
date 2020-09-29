namespace ConsoleBank.Modelos.Negocio
{
    public class Cliente
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Profissao { get; set; }

        public override bool Equals(object obj)
        {
            //Cliente clienteComparacao = (Cliente)obj;
            Cliente clienteComparacao = obj as Cliente;

            if (clienteComparacao == null)
            {
                return false;
            }

            return Cpf == clienteComparacao.Cpf ;
        }
    }
}
