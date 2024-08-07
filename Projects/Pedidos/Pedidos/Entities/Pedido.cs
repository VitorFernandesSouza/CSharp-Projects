using Pedidos.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pedidos.Entities
{
    class Pedido
    {
        public Cliente Cliente { get; set; }
        public DateTime Momento { get; set; } = DateTime.Now;
        public StatusPedido Status { get; set; }
        public List<Item> ListaItens { get; set; } = new List<Item>();

        public Pedido(Cliente cliente, DateTime momento, StatusPedido status)
        {
            Cliente = cliente;
            Momento = momento;
            Status = status;
        }

        public Pedido()
        {
        }

        public void AddPedido(Item pedido)
        {
            ListaItens.Add(pedido);
        }

        public void RemoverPedido(Item pedido)
        {
            ListaItens.Remove(pedido);
        }

        public double Total()
        {
            double sum = 0.0;
            Produto produto = new Produto();
            foreach (Item item in ListaItens)
            {
                sum += item.SubTotal(item.Preco,item.Quantidade);
            }
            return sum;
        }

        public override string ToString()
        {
            
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Hora do pedido: " + Momento.ToString("dd/MM/yyyy HH:mm"));
            sb.AppendLine();
            sb.AppendLine("Status do pedido: " + Status);
            sb.AppendLine();
            sb.AppendLine("Cliente: " + Cliente );
            sb.AppendLine();
            sb.AppendLine("Itens:");
            foreach (Item obj in ListaItens)
            {
                sb.AppendLine(obj.ToString());
            }
            sb.AppendLine("Total: $" + Total().ToString("F2", CultureInfo.InvariantCulture));
            return sb.ToString();
        }
    }
}
