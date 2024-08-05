using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Banco
{
    public class Conta
    {
        public int Taxa { get; private set; } = 5;
        public int IdConta;
        public string Titular;
        public double Saldo;

        public Conta(int idConta, string titular, double saldo)
        {
            IdConta = idConta;
            Titular = titular;
            Saldo = 0;
        }

        public void Deposito(double saldoIncial)
        {
            Saldo = saldoIncial;
        }

        public void Saque(double saque)
        {
            Saldo = Saldo - (saque + Taxa);
        }
        public override string ToString()
        {
            return $"Conta: {IdConta}, Titular: {Titular}, Saldo: {Saldo:C}";
        }

    }
}
