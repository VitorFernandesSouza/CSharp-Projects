using ConsultasLinq.Entities;

namespace ConsultasLinq
{
    public class Program
    {
        static void Main(string[] args)
        {
            Categorias c1 = new Categorias() { Id = 1, Nome = "Ferramentas", Tipo = 2 };
            Categorias c2 = new Categorias() { Id = 2, Nome = "Computadores", Tipo = 1 };
            Categorias c3 = new Categorias() { Id = 3, Nome = "Eletrônicos", Tipo = 1 };

            List<Produtos> produtos = new List<Produtos>() {
                new Produtos() { Id = 1,  Nome = "Computer", Preco = 1100.0, Categoria = c2 },
                new Produtos() { Id = 2,  Nome = "Hammer", Preco = 90.0, Categoria = c1 },
                new Produtos() { Id = 3,  Nome = "TV", Preco = 1700.0, Categoria = c3 },
                new Produtos() { Id = 4,  Nome = "Notebook", Preco = 1300.0, Categoria = c2 },
                new Produtos() { Id = 5,  Nome = "Saw", Preco = 80.0, Categoria = c1 },
                new Produtos() { Id = 6,  Nome = "Tablet", Preco = 700.0, Categoria = c2 },
                new Produtos() { Id = 7,  Nome = "Camera", Preco = 700.0, Categoria = c3 },
                new Produtos() { Id = 8,  Nome = "Printer", Preco = 350.0, Categoria = c3 },
                new Produtos() { Id = 9,  Nome = "MacBook", Preco = 1800.0, Categoria = c2 },
                new Produtos() { Id = 10, Nome = "Sound Bar", Preco = 700.0, Categoria = c3 },
                new Produtos() { Id = 11, Nome = "Level", Preco = 70.0, Categoria = c1 }
            };

            var resultado1 = produtos.Where(x => x.Categoria.Tipo == 1 && x.Preco < 900);

            Console.WriteLine("Produtos da categoria 1 e mais baratos que R$ 900");
            foreach (var item in resultado1)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            var resultado2 = produtos.Where(x => x.Categoria.Nome == "Ferramentas").Select(x => x.Nome);

            Console.WriteLine("Nomes dos produtos da categoria 'Ferramentas'");
            foreach (var item in resultado2)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            Console.WriteLine("Nome dos Produtos que começam com a letra 'C' ");
            var resultado3 = produtos.Where(c => c.Nome[0] == 'C').Select(c => new {c.Nome, c.Preco, CatrgoriaNome = c.Categoria.Nome});


            foreach (var item in resultado3)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Ordenando: ");
            var resultado4 = produtos.Where(c => c.Categoria.Tipo == 1).OrderBy(c => c.Preco).ThenBy(c => c.Nome);

            foreach (var item in resultado4)
            {
                Console.WriteLine(item);
            }

        }
    }
}
