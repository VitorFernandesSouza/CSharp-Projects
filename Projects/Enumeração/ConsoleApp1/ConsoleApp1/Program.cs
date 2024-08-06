using ConsoleApp1.Entities;
using ConsoleApp1.Entities.Enums;
using System;

namespace ConsoleApp1 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Order pedido = new Order
            {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PedingPayment,
            };

            Console.WriteLine(pedido);

            OrderStatus os = Enum.Parse<OrderStatus>("Delivered"); 
            Console.WriteLine(os);

        }
    }
}