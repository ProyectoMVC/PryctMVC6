using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Final.Entities
{
    // This project can output the Class library as a NuGet Package.
    // To enable this option, right-click on the project and select the Properties menu item. In the Build tab select "Produce outputs on build".
    public class Producto
    {
        [Key]
        public int IdProducto { get; set; }

        [Display(Name = "Nombre producto")]
        [Required(ErrorMessage = "Debe ingresar el campo nombre producto")]
        [MaxLength(25, ErrorMessage = "El campo Nombre producto debe exceder los 25 caracteres")]
        public string NombreProducto { get; set; }

        [Display(Name = "Descripción producto")]
        [Required(ErrorMessage = "Debe ingresar el campo descripción producto")]
        [MaxLength(100, ErrorMessage = "El campo no debe exceder los 100 caracteres.")]
        public string Descripcion { get; set; }

        [ForeignKey("Categoria")]
        public int IdCategoria { get; set; }

        [Display(Name = "Precio de venta")]
        [Required(ErrorMessage = "Debe ingresar el campo precio.")]
        [DataType(DataType.Currency)]
        public decimal Precio { get; set; }

        [Display(Name = "Stock producto")]
        [Required(ErrorMessage = "Debe ingresar el campo stock.")]
        public int Existencia { get; set; }

        public DateTime FechaRegistro { get; set; }

        public DateTime? FechaModificacion { get; set; }

        public bool FlagAnulado { get; set; }

        public virtual Categoria Categoria { get; set; }
    }
}
