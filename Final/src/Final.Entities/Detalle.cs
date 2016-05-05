using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Final.Entities
{
    public class Detalle
    {
        public decimal Cantidad { get; set; }

        public decimal Precio { get; set; }

        public virtual Pedido IdPedido{ get; set; }

        public virtual Producto IdProducto { get; set; }
    }
}
