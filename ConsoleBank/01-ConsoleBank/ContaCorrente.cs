namespace ConsoleBank
{
    public class ContaCorrente
    {
        public Cliente titular;
        public int agencia;
        public int numero;
        private double saldo = 100;

        public double ConsultarSaldo()
        {
            return saldo;
        }
        public bool Sacar(double valor)
        {
            if (saldo < valor || valor <= 0)
            {
                return false;
            }

            saldo -= valor;
            return true;
        }

        public void Depositar(double valor)
        {
            if (valor <= 0)
            {
                return;
            }

            saldo += valor;
        }

        public bool Transferir(double valor, ContaCorrente contaDestino)
        {
            if (saldo < valor || valor < 0)
            {
                return false;
            }

            saldo -= valor;
            contaDestino.Depositar(valor);
            return true;
        }
    }
}