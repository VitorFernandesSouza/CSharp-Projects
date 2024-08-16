using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Action.Entities
{
    class Produtos
    {
        public string Nome { get; set; }
        public double Preco { get; set; }

        public Produtos()
        {
        }

        public Produtos(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }
        override public string ToString()
        {
            return Nome + ", " + Preco.ToString("F2");
        }
    }
}
