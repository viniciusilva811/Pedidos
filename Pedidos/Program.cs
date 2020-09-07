using System;
using System.Globalization;
using Pedidos.Entidades;
using Pedidos.Entidades.Enumerados;

namespace Pedidos

{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter client data: ");
            Console.Write("Nome: ");

            string Nome = Console.ReadLine();
            Console.Write("Email: ");

            string email = Console.ReadLine();
            Console.Write("Data de aniversario (DD/MM/YYYY): ");

            DateTime aniversario = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Entre com os dados do pedido: ");

            Console.Write("Status: ");
            StatusPedido statusP = Enum.Parse<StatusPedido>(Console.ReadLine());

            Cliente cliente = new Cliente(Nome, email, aniversario);
            Pedido pedido = new Pedido(DateTime.Now, statusP, cliente);

            Console.Write("Quais produtos ? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Enter #{i} item data:");
                Console.Write("Nome do produto: ");
                string productName = Console.ReadLine();
                Console.Write("Preco do produto : ");
                double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Produto produto = new Produto();

                Console.Write("Quantidade: ");
                int quantidade = int.Parse(Console.ReadLine());

                OrdemPedido ordemPedido = new OrdemPedido(quantidade, preco, produto);

                pedido.AddItem(ordemPedido);
            }

            Console.WriteLine();
            Console.WriteLine("pedido:");
            Console.WriteLine(pedido); 
        }
    }
}