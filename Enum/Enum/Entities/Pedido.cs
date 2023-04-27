using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Enum.Entities.Enums;

namespace Enum.Entities
{
    internal class Pedido
    {
        public int Id { get; set; }
        public DateTime Moment { get; set; }
        public PedidoStatus Status { get; set; }

        public override string ToString()
        {
            return ($"Id: {Id}, Data/Hora: {Moment}, Status: {Status}");
        }
    }
}
