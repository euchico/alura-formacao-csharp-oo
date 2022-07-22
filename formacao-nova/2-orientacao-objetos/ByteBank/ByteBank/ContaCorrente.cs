using ByteBank.Titular;

namespace ByteBank
{
    public class ContaCorrente
    {
        public Cliente titular;

        public string conta;
        public int numeroAgencia;
        public string nomeAgencia;
        public double saldo;

        public bool Sacar(double valor)
        {
            if (this.saldo < valor || valor < 0)
            {
                return false;
            }

            this.saldo -= valor;
            return true;
        }

        public void Depositar(double valor)
        {
            this.saldo += valor;
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