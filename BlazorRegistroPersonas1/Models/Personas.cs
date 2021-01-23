using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorRegistroPersonas1.Models
{
    public class Personas
    {
        [Key]
        public int PersonaId { get; set; }

        public string Nombres { get; set; }

        public string Telefono { get; set; }

        public string Cedula { get; set; }

        public string Direccion { get; set; }

        public DateTime FechaNacimiento { get; set; }

    }
}
