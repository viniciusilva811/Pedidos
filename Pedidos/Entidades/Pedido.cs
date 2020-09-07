using Pedidos.Entidades.Enumerados;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Pedidos.Entidades
{
    class Pedido
    {
        public DateTime Moment { get; set; }
    public StatusPedido StatusP { get; set; }
    public Cliente Cliente { get; set; }
    public List<OrdemPedido> Items { get; set; } = new List<OrdemPedido>();

    public Pedido()
    {
    }

    public Pedido(DateTime moment, StatusPedido statusP, Cliente cliente)
    {
        Moment = moment;
        StatusP = statusP;
        Cliente = cliente;
    }

    public void AddItem(OrdemPedido item)
    {
        Items.Add(item);
    }

    public void RemoveItem(OrdemPedido item)
    {
        Items.Remove(item);
    }

    public double Total()
    {
        double sum = 0.0;
        foreach (OrdemPedido item in Items)
        {
            sum += item.SubTotal();
        }
        return sum;
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine("Order moment: " + Moment.ToString("dd/MM/yyyy HH:mm:ss"));
        sb.AppendLine("Order status: " + StatusP);
        sb.AppendLine("Client: " + Cliente);
        sb.AppendLine("Order items:");
        foreach (OrdemPedido item in Items)
        {
            sb.AppendLine(item.ToString());
        }
        sb.AppendLine("Total price: $" + Total().ToString("F2", CultureInfo.InvariantCulture));
        return sb.ToString();
    }
}
}