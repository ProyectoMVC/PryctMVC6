using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Final.Entities
{
    public class Pedido
    {
        [Key]
        public int IdPedido { get; set; }

        [Display(Name ="Número Orden")]
        public int NumeroPedido { get; set; }

        [ForeignKey("Cliente")]
        public int IdCliente { get; set; }

        [ForeignKey("Estado")]
        public string IdEstado { get; set; }

        public string FormaPago { get; set; }

        public DateTime FechaRegistro { get; set; }

        public virtual Cliente Cliente { get; set; }
        public virtual Estado Estado { get; set; }

        public virtual ICollection<Detalle> Detalle { get; set; }
    }
}
