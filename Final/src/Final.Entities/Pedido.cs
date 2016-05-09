using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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

        [Display(Name = "Cliente")]
        public string Cliente { get; set; }

        [Display(Name = "Estado")]
        public string Estado { get; set; }

        public string FormaPago { get; set; }

        public DateTime FechaRegistro { get; set; }

        public DateTime FechaModificacion { get; set; }

        public virtual Cliente IdCliente { get; set; }
        public virtual Estado IdEstado { get; set; }
    }
}
