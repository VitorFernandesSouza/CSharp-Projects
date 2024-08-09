using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAbstratas.Entities
{
    class ContaComercial: Conta
    {
        public double LimiteSaque { get; set; }

        public ContaComercial() { }

        public ContaComercial(int numero, string titular, double saldo, double limiteSaque)
            : base(numero, titular, saldo)
        {
            LimiteSaque = limiteSaque;
        }

        public override void Saque(double quantia)
        {;
            Saldo -= quantia + 5.0;            
        }
    }
}
