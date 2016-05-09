using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Final.Entities
{
    public class Estado
    {
        [Key]
        public int IdEstado { get; set; }

        [Display(Name = "Estado")]
        [MaxLength(20, ErrorMessage = "El campo nombre no debe pasar 20 caracteres")]
        [Required(ErrorMessage = "Debe ingresar el campo estado")]
        public string NombreEstado { get; set; }
        public DateTime FechaRegistro { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public bool FlagAnulado { get; set; }
        public virtual ICollection<Pedido> Pedido { get; set; }
    }
}
