using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo.Entities
{
    class FuncionarioTerceirizado : Funcionario
    {
        public double DespesaAdicional { get; set; }

        public FuncionarioTerceirizado() { }
        public FuncionarioTerceirizado(string nome, int horas, double valorPorHora,double despesaAdicional) : base(nome, horas, valorPorHora)
        {
            DespesaAdicional = despesaAdicional;
        }

        public sealed override double Pagamento()
        {
            return base.Pagamento() + (DespesaAdicional * 1.1);
        }

    }
}
