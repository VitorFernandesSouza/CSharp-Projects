using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casting.Entities
{
    class ContaPoupanca : Conta
    {
        public double Juros { get; set; }

        public ContaPoupanca() { }
        public ContaPoupanca(int numero, string titular, double saldo, double juros) : base(numero, titular, saldo)
        {
            Juros = juros;
        }

        public void AtualizaSaldo()
        {
            Saldo += Saldo * Juros;
        }
    }
}