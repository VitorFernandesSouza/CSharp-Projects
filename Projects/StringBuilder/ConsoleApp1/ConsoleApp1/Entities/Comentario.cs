using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Entities
{
     class Comentario
    {
        public string Texto { get; set; }

        public Comentario(string texto)
        {
            Texto = texto;
        }
        public Comentario()
        {
        }
    }
}
