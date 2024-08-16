using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsultasLinq.Entities
{
    public class Produtos
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public double Preco { get; set; }
        public Categorias Categoria { get; set; }

        public override string ToString()
        {
            return Id
            + ", "
            + Nome
                + ", "
                + Preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + Categoria.Nome
                + ", "
                + Categoria.Tipo;
        }
    }
}
