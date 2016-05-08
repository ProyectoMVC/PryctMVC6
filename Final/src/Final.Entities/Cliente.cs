using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Final.Entities
{
    public class Cliente 
    {
        public int IdCliente { get; set; }
        public string NombreCliente { get; set; }
        public int Apellido { get; set; }
        public int Correo { get; set; }
        public int Telefono { get; set; }
        public string Direccion { get; set; }
        public DateTime FechaRegistro { get; set; }
        public DateTime FechaModificacion { get; set; }
        public bool FlagAnulado { get; set; }
    }
}
