using Pedidos.Entities;
using Pedidos.Entities.Enums;
using System;


namespace Pedidos;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Entre com os dados do Cliente");
        Console.Write("Nome: ");
        string nome = Console.ReadLine();
        Console.Write("Email: ");
        string email = Console.ReadLine();
        Console.Write("Data de Nascimento: ");
        DateTime nascimento = DateTime.Parse(Console.ReadLine());
        Console.WriteLine();
        Cliente cliente1 = new Cliente(nome, email, nascimento);
        Console.Write("Qual o status do produto? ");
        StatusPedido status = Enum.Parse<StatusPedido>(Console.ReadLine());

        Cliente cliente = new Cliente(nome, email, nascimento);
        Pedido pedido = new Pedido(cliente, DateTime.Now, status);


        Console.Write("Quanto itens terão no seu pedido? ");
        int item = int.Parse(Console.ReadLine());


        for (int i = 1; i <= item; i++)
        {
            Console.WriteLine();
            Console.WriteLine($"Dados do {i}º pedido");
            Console.Write("Nome produto: ");
            string produtoNome = Console.ReadLine();
            Console.Write("Preço do produto: ");
            double preco = double.Parse(Console.ReadLine());
            Console.Write("Quantidade de produtos: ");
            int qtd = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Produto produto1 = new Produto(produtoNome, preco);

            Console.WriteLine(produto1);
            Item itens = new Item(qtd, preco, produto1);
            Console.WriteLine("Total a se pagar: " + itens.SubTotal(preco, qtd));

            pedido.AddPedido(itens);

        }
        Console.WriteLine(pedido);


    }
}