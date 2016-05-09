using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Final.Entities
{
    public class Detalle
    {
        [Key]
        [Column(Order = 1)]
        [ForeignKey("Pedido")]
        public int IdPedido { get; set; }

        [Key]
        [Column(Order = 2)]
        [ForeignKey("Producto")]
        public int IdProducto { get; set; }
        public decimal Cantidad { get; set; }

        [DataType(DataType.Currency)]
        public decimal Precio { get; set; }

        public virtual Pedido Pedido{ get; set; }

        public virtual Producto Producto { get; set; }
    }
}
