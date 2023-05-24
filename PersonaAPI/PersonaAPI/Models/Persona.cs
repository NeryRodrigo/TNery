using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PersonaAPI.Models
{
    public class Persona
    {
        public int Id { get; set; }
        public string nombre_completo { get; set; }
        public string nro_documento { get; set; }
        [Required(ErrorMessage = "El correo es obligatorio")]
        public string correo_electronico { get; set; }
        public string telefono { get; set; }
        [Required(ErrorMessage = "La fecha es obligatorio")]
        public DateTime fecha_nacimiento { get; set; }
    }
}
