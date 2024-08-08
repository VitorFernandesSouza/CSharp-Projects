using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioFixacao.Entities
{
    class ProdutosUsados : Produto
    {
        public DateTime DataFabricacao { get; set; }

        public ProdutosUsados() { }
        public ProdutosUsados(string nome, double preco, DateTime dataFabricacao) 
            : base(nome,preco)
        {
            DataFabricacao = dataFabricacao;
        }

        public override string Etiqueta()
        {
            return $"Produto Usado - {Nome}, R$ {Preco}, Data de Fabricação: {DataFabricacao}";
        }
    }
}
