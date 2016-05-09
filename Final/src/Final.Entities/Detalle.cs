using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Final.Entities
{
    public class Detalle
    {

        public decimal Cantidad { get; set; }

        [DataType(DataType.Currency)]
        public decimal Precio { get; set; }

        public virtual Pedido IdPedido{ get; set; }

        public virtual Producto IdProducto { get; set; }
    }
}
