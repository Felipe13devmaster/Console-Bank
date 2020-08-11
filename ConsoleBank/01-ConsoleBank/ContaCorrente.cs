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
            if (this.saldo < valor || valor <= 0)
            {
                return false;
            }

            this.saldo -= valor;
            return true;
        }

        public void Depositar(double valor)
        {
            if (valor <= 0)
            {

            }
            else
            {
                this.saldo += valor;
            }
        }

        public bool Transferir(double valor, ContaCorrente contaDestino)
        {
            if (this.saldo < valor || valor < 0)
            {
                return false;
            }

            this.saldo -= valor;
            contaDestino.Depositar(valor);
            return true;
        }
    }
}