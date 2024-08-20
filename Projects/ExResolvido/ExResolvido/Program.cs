using System;
using System.Collections.Generic;
using ExResolvido.Entities;
using System.IO;
namespace ExResolvido
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Cole aqui o caminho do arquivo: ");
            string arquivo = Console.ReadLine();

            List<Produtos> lista = new List<Produtos>();    

            using (StreamReader sr = File.OpenText(arquivo))
            {
                while (!sr.EndOfStream)
                {
                    string[] campos = sr.ReadLine().Split(',');
                    string nome = campos[0];
                    double preco = double.Parse(campos[1], System.Globalization.CultureInfo.InvariantCulture);
                    lista.Add(new Produtos(nome, preco));
                }
            }

            var media = lista.Select(p => p.Preco).DefaultIfEmpty(0).Average();
            Console.WriteLine("Preço médio: " + media.ToString("F2"));

            var ordem = lista.Where(x => x.Preco < media).OrderByDescending(x => x.Nome).Select(p => p.Nome);

            foreach(string nome in ordem)
            {
                Console.WriteLine(nome);
            }
            
        }
    }
}
