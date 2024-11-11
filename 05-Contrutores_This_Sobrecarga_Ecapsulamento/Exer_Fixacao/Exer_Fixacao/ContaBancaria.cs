using System.Globalization;

namespace Exer_Fixacao
{
    internal class ContaBancaria
    {
        public int NumeroConta {  get; private set; }

        public string NomeTitular { get; set; }

        public double Saldo { get; private set; }

        public ContaBancaria(int numero_conta, string nome_titular)
        {
            NumeroConta = numero_conta;
            NomeTitular = nome_titular;
            Saldo = 0.0;
        }
        
        public ContaBancaria(int numero_conta, string nome_titular, double deposito_inicial) : this(numero_conta, nome_titular)
        {
            Deposito(deposito_inicial);
        }

        public void Deposito(double quantia)
        {
            Saldo += quantia;
        }

        public void Saque(double quantia)
        {
            Saldo -= quantia + 5.0;
        }

        public override string ToString()
        {
            return "Número da conta: " + NumeroConta 
               + "\nNome do Titular: " + NomeTitular
               + "\nSaldo R$ " + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
