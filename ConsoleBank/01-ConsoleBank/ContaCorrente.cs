namespace ConsoleBank
{
    public class ContaCorrente
    {
        public Cliente Titular { get; set; }
        public int Agencia { get; set; }
        public int Numero { get; set; }

        private double _saldo = 100;

        public double Saldo
        {
            get
            {
                return _saldo;
            }
            set
            {
                _saldo = value;
            }
        }

        public double ConsultarSaldo()
        {
            return _saldo;
        }
        public bool Sacar(double valor)
        {
            if (_saldo < valor || valor <= 0)
            {
                return false;
            }

            _saldo -= valor;
            return true;
        }

        public void Depositar(double valor)
        {
            if (valor <= 0)
            {
                return;
            }

            _saldo += valor;
        }

        public bool Transferir(double valor, ContaCorrente contaDestino)
        {
            if (_saldo < valor || valor < 0)
            {
                return false;
            }

            _saldo -= valor;
            contaDestino.Depositar(valor);
            return true;
        }
    }
}