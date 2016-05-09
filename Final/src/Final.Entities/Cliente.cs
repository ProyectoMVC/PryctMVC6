using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Final.Entities
{
    public class Cliente 
    {
        [Key]
        public int IdCliente { get; set; }

        [Display(Name = "Nombre")]
        [Required(ErrorMessage = "Debe ingresar el campo nombre")]
        [MaxLength(25, ErrorMessage = "El campo nombre no debe exceder los 25 caracteres")]
        public string NombreCliente { get; set; }

        [Display(Name = "Apellido")]
        [Required(ErrorMessage = "Debe ingresar el campo apellido")]
        [MaxLength(25, ErrorMessage = "El campo apellido debe exceder los 25 caracteres")]
        public int Apellido { get; set; }

        [Display(Name = "Correo")]
        [RegularExpression(@"^[_a-z0-9-]+(\.[_a-z0-9-]+)*@[a-z0-9-]+(\.[a-z0-9-]+)*(\.[a-z]{2,3})$", ErrorMessage = "Debe ingresar un correo válido")]
        [Required(ErrorMessage = "Debe ingresar el campo correo")]
        [MaxLength(60, ErrorMessage = "El campo apellido debe exceder los 60 caracteres")]
        public int Correo { get; set; }

        [Display(Name = "Teléfono")]
        [MaxLength(8, ErrorMessage = "El campo teléfono no debe exceder los 8 caracteres")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^[1-9]{3}-[0-9]{4}$", ErrorMessage = "Debe ingresar un número telefonico válido")]
        [Required(ErrorMessage = "Debe ingresar el campo teléfono")]
        public int Telefono { get; set; }

        [Display(Name = "Dirección")]
        [Required(ErrorMessage = "Debe ingresar el campo dirección")]
        [MaxLength(100, ErrorMessage = "El campo dirección no debe exceder los 100 caracteres")]
        public string Direccion { get; set; }
        public DateTime FechaRegistro { get; set; }
        public DateTime FechaModificacion { get; set; }
        public bool FlagAnulado { get; set; }

    }
}
