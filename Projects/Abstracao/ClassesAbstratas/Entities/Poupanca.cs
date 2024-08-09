using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAbstratas.Entities
{
    class Poupanca : Conta
    {
        public double TaxaJuros { get; set; }

        public Poupanca() { }

        public Poupanca(int numero, string titular, double saldo, double taxaJuros)
            : base(numero, titular, saldo)
        {
            TaxaJuros = taxaJuros;
        }

        override public void Saque(double quantia)
        {
            base.Saque(quantia);
            Saldo -= 2.0;
        }
    }
}
