using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contratos.Entities
{
     class Departamento
    {
        public string Nome { get; set; }

        public Departamento(string nome)
        {
            Nome = nome;
        }
    }
}
