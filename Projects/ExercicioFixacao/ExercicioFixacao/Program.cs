using ExercicioFixacao.Entities;
using System;
using System.Globalization;


namespace ExercicioFixacao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Produto> produtos = new List<Produto>();
            Console.Write("Qual a quantidade de produtos? ");
            int qtd = int.Parse(Console.ReadLine());

            for (int i = 1; i <= qtd; i++)
            {
                Console.WriteLine();
                Console.WriteLine("Adicione os dados do produto:");
                Console.Write("Nacional, Importado ou Usado? (n, i, u) ");
                char p = char.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Preço: ");
                double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (p == 'n')
                {
                    produtos.Add(new Produto(nome, preco));
                }
                else if (p == 'i')
                {
                    Console.Write("Custo Importação: ");
                    double custo = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                    produtos.Add(new ProdutoImportado(nome, preco, custo));
                    
                }
                else
                {
                    Console.Write("Data de fabricação: ");
                    DateTime data = DateTime.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    string fab = data.ToString("dd/MM");
                    produtos.Add(new ProdutosUsados(nome, preco, data));
                }

                foreach (Produto produto in produtos)
                {
                    Console.WriteLine();
                    Console.WriteLine(produto.Etiqueta()); 
                }
            }


        }
    }
}