using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Final.Entities
{
    public class Pedido
    {
        public int IdPedido { get; set; }

        public int NumeroPedido { get; set; }

        public int Cliente { get; set; }

        public string Estado { get; set; }

        public int IdEstado { get; set; }

        public int IdFormaPago { get; set; }

        public DateTime FechaRegistro { get; set; }

        public DateTime FechaModificacion { get; set; }

        public virtual Cliente IdCliente { get; set; }
    }
}
