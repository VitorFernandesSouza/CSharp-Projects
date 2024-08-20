using System;
using System.Linq;
using System.Collections.Generic;
using AgregacaoAgrupamento.Entities;

namespace AgregacaoAgrupamento
{
    class Program
    {

        static void Print<T>(string message, IEnumerable<T> collection)
        {
            Console.WriteLine(message);
            foreach (T obj in collection)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {

            Categorias c1 = new Categorias() { Id = 1, Nome = "Tools", Etiqueta = 2 };
            Categorias c2 = new Categorias() { Id = 2, Nome = "Computers", Etiqueta = 1 };
            Categorias c3 = new Categorias() { Id = 3, Nome = "Electronics", Etiqueta = 1 };

            List<Produtos> products = new List<Produtos>() {
                new Produtos() { Id = 1, Nome = "Computer", Preco = 1100.0, Categoria = c2 },
                new Produtos() { Id = 2, Nome = "Hammer", Preco = 90.0, Categoria = c1 },
                new Produtos() { Id = 3, Nome = "TV", Preco = 1700.0, Categoria = c3 },
                new Produtos() { Id = 4, Nome = "Notebook", Preco = 1300.0, Categoria = c2 },
                new Produtos() { Id = 5, Nome = "Saw", Preco = 80.0, Categoria = c1 },
                new Produtos() { Id = 6, Nome = "Tablet", Preco = 700.0, Categoria = c2 },
                new Produtos() { Id = 7, Nome = "Camera", Preco = 700.0, Categoria = c3 },
                new Produtos() { Id = 8, Nome = "Printer", Preco = 350.0, Categoria = c3 },
                new Produtos() { Id = 9, Nome = "MacBook", Preco = 1800.0, Categoria = c2 },
                new Produtos() { Id = 10, Nome = "Sound Bar", Preco = 700.0, Categoria = c3 },
                new Produtos() { Id = 11, Nome = "Level", Preco = 70.0, Categoria = c1 }
            };

            var r1 = products.Where(p => p.Categoria.Etiqueta == 1 && p.Preco < 900.0);
            Print("Etiqueta 1 e Preco < 900:", r1);

            var r2 = products.Where(p => p.Categoria.Nome == "Tools").Select(p => p.Nome);
            Print("Nome das ferramentas", r2);

            var r3 = products.Where(p => p.Nome[0] == 'C').Select(p => new { p.Nome, p.Preco, CategoriaNome = p.Categoria.Nome });
            Print("Produtos que começam com 'C' ", r3);

            var r4 = products.Where(p => p.Categoria.Etiqueta == 1).OrderBy(p => p.Preco).ThenBy(p => p.Nome);
            Print("Etiqueta 1 ordenada por preço e depois por nome", r4);

            var r5 = r4.Skip(2).Take(4);
            Print("Etiqueta 1 ordenada por preço e depois skip 2 nomes e pegar 4", r5);

            var r6 = products.FirstOrDefault();
            Console.WriteLine("First or default: " + r6);
            var r7 = products.Where(p => p.Preco > 3000.0).FirstOrDefault();
            Console.WriteLine("First or default " + r7);
            Console.WriteLine();

            var r8 = products.Where(p => p.Id == 3).SingleOrDefault();
            Console.WriteLine("Single or default: " + r8);
            var r9 = products.Where(p => p.Id == 30).SingleOrDefault();
            Console.WriteLine("Single or default: " + r9);
            Console.WriteLine();

            var r10 = products.Max(p => p.Preco);
            Console.WriteLine("Max Preco: " + r10);
            var r11 = products.Min(p => p.Preco);
            Console.WriteLine("Min Preco: " + r11);
            var r12 = products.Where(p => p.Categoria.Id == 1).Sum(p => p.Preco);
            Console.WriteLine("Categoria 1 soma Precos: " + r12);
            var r13 = products.Where(p => p.Categoria.Id == 1).Average(p => p.Preco);
            Console.WriteLine("Categoria 1 Media Precos: " + r13);
            var r14 = products.Where(p => p.Categoria.Id == 5).Select(p => p.Preco).DefaultIfEmpty(0.0).Average();
            Console.WriteLine("Categoria 5 Media Precos: " + r14);
            var r15 = products.Where(p => p.Categoria.Id == 1).Select(p => p.Preco).Aggregate(0.0, (x, y) => x + y);
            Console.WriteLine("Categoria 1 aggregate: " + r15);
            Console.WriteLine();

            var r16 = products.GroupBy(p => p.Categoria);
            foreach (IGrouping<Categorias, Produtos> group in r16)
            {
                Console.WriteLine($"Categoria {group.Key.Nome} :");
                foreach (Produtos p in group)
                {
                    Console.WriteLine(p);
                }
                Console.WriteLine();
            }
        }
    }
}
