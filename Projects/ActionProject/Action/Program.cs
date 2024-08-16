using Action.Entities;
namespace Action
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Produtos> list = new List<Produtos>();

            list.Add(new Produtos("TV", 900.00));
            list.Add(new Produtos("Mouse", 50.00));
            list.Add(new Produtos("Tablet", 350.50));
            list.Add(new Produtos("HD Case", 80.90));

            // Quando uma função é void e queremos criar um labda com ela, precisamos coloca-lá entre parenteses
            Action<Produtos> act = p => { p.Preco += p.Preco * 0.1; };

            list.ForEach(p => { p.Preco += p.Preco * 0.1; }); // pode ser feito assim tbm

            foreach (Produtos p in list)
            {
                Console.WriteLine(p);
            }
        }
    }
}
