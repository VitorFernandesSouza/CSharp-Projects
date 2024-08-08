using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas
{
    public class Funcionario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public double Salario { get; set; }

        public Funcionario(int id, string nome, double salario)
        {
            Id = id;
            Nome = nome;
            Salario = salario;
        }

        public double AumentarSalario(double porcentagem)
        {
            return Salario = Salario + ((Salario / 100) * porcentagem);
        }

        override public string ToString()
        {
            return Id + ", " + Nome + ", " + Salario;
        }

    }
}
