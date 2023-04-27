using System;
using Enum.Entities;
using Enum.Entities.Enums;
namespace Enum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pedido pedido = new Pedido
            {
                Id = 1,
                Moment = DateTime.Now,
                Status = PedidoStatus.PagamentoPendente
            };

            Console.WriteLine(pedido);
        }
    }
}