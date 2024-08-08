using System;
using Enum.Entities;
using Enum.Entities.Enums;

namespace Enum // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Order pedido = new Order
            {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };
            
            string txt = OrderStatus.PendingPayment.ToString();
            Console.WriteLine(txt);
        }
    }
}