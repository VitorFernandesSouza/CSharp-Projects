using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sobreposicao.Entities
{
    class Conta
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

        public virtual void Saque(double quantia) // 'virtual' significa que esse metodo pode ser sobreescrito.
        {
            Saldo -= quantia + 5;
        }

        public void Deposito(double quantia)
        {

            Saldo += quantia;
        }
    }
}

