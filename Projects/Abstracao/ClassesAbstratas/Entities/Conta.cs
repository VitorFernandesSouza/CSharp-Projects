using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAbstratas.Entities
{
    abstract class Conta
    {
        public int Numero { get; private set; }
        public string Titular { get; private set; }
        public double Saldo { get; protected set; }

        public Conta() { }

        public Conta(int numero, string titular, double saldo)
        {
            Numero = numero;
            Titular = titular;
            Saldo = saldo;
        }

        public virtual void Saque(double quantia)
        {
            Saldo -= quantia + 5.0;
        }

        public void Deposito(double quantia)
        {
            Saldo += quantia;
        }
    }
}
