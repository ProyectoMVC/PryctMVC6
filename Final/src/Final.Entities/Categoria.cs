using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Final.Entities
{
    public class Categoria
    {
        [Key]
        public int IdCategoria { get; set; }

        [Display(Name = "Categoría")]
        [MaxLength(20, ErrorMessage = "No debe exceder los 20 caracteres")]
        [Required(ErrorMessage = "Debe ingresar el campo Categoría")]
        public string NombreCategoria { get; set; }
        public DateTime FechaRegistro { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public bool FlagAnulado { get; set; }
        public virtual ICollection<Producto> Producto { get; set; }
    }
}
