using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DTOs
{
    public class PersonaCDTO
    {      
        [Required]
        [StringLength(maximumLength: 100)]
        public string NombrePersona { get; set; }

        [Required]
        [StringLength(maximumLength: 100)]
        public string ApellidoPersona { get; set; }

        [Required]
        [StringLength(maximumLength: 100)]
        public string PaísPrecedencia { get; set; }

        [Required]
        [StringLength(maximumLength: 100)]
        public string CorreoElectronico { get; set; }

        public string Pasaporte { get; set; }

        [Required]
        public int UsuarioID { get; set; }
    }
}
