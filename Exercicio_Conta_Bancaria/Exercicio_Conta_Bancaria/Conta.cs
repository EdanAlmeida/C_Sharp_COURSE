using System;
using System.Globalization;

namespace Exercicio_Conta_Bancaria
{
    class Conta
    {
        public int Numero { get; private set; }
        public string Titular { get; set; }
        public double Saldo { get; private set; }

        public Conta(int numero, string titular)
        {
            Numero = numero;
            Titular = titular;
        }

        //Melhor usar o argumento 'depositoInicial' para deixar a responsabilidade para o método de depósito
        //Isso facilita a manutenção do código e deixa a lógica mais bem feita
        //Lógica de depósito encapsulada no método
        public Conta(int numero, string titular, double depositoInicial) : this(numero, titular)
        {
            Deposito(depositoInicial);
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
            return "Conta "
                + Numero
                + ", Titular: "
                + Titular
                + ", Saldo $ "
                + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
