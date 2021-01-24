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
        [Required(ErrorMessage = "Es obligatorio introducir un Nombre.")]
        public string Nombres { get; set; }
        [Required(ErrorMessage = "Es obligatorio introducir un Número Telefónico .")]
        public string Telefono { get; set; }
        [Required(ErrorMessage = "Es obligatorio introducir una Cédula.")]
        public string Cedula { get; set; }
        [Required(ErrorMessage = "Es obligatorio introducir una dirección.")]
        public string Direccion { get; set; }
        [Required(ErrorMessage = "Es obligatorio introducir una fecha de nacimiento")]
        public DateTime FechaNacimiento { get; set; }
    }
}
