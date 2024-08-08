using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioFixacao.Entities
{
    class ProdutoImportado : Produto
    {
        public double CustoImportacao { get; set; }


        public ProdutoImportado() { }
        public ProdutoImportado(string nome, double preco, double custoImportacao) 
            : base(nome,preco)
        {
            CustoImportacao = custoImportacao;
        }

        public double PrecoTotal()
        {
            return Preco + CustoImportacao;
        }

        public override string Etiqueta()
        {
            return $"Produto Importado - {Nome}, Preço: {Preco}, Custo de importação: {CustoImportacao}, Preço Total: R$ {PrecoTotal()}"; 
        }
    }
}
