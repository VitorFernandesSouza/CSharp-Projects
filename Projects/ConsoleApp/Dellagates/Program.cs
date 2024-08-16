using Dellagates.Entities;
namespace Dellagates
{
    internal class Program
    {
        static void Main(string[] args)
        {
           // Predicate 

            List<Produtos> list = new List<Produtos>();

            list.Add(new Produtos("TV", 900.00));
            list.Add(new Produtos("Mouse", 50.00));
            list.Add(new Produtos("Tablet", 350.50));
            list.Add(new Produtos("HD Case", 80.90));

            list.RemoveAll(ProdutosDell);

            foreach (Produtos p in list)
            {
                Console.WriteLine(p);
            }
        }

        public static bool ProdutosDell(Produtos p)
        {
            return p.Preco >= 100.0;
        }
    }
}
