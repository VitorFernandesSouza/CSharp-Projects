using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sobreposicao.Entities
{
    class ContaPoupanca : Conta
    {
        public double Juros { get; set; }

        public ContaPoupanca() { }

        public ContaPoupanca(int numero, string titular, double saldo, double juros) 
            : base(numero, titular,saldo)
        {
            Juros = juros;
        }

        public void AtualizarSaldo()
        {
            Saldo += Saldo * Juros;
        }

        public sealed override void Saque(double quantia) // sealed = selar o método, proibindo novas sobreposições(override)
        {
            base.Saque(quantia); // Forma de reaproveitar o método da SUPERCLASSE Conta
            Saldo -= quantia;
        }
    }
}
