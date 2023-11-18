using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DTOs
{
    public class UsuarioCDTO
    {
        [Required]
        [StringLength(maximumLength: 100)]
        public string NombreUsuario { get; set; }

        [Required]
        [StringLength(maximumLength: 100)]
        public string Contraseña { get; set; }

        [Required]
        public DateTime FechaCreación { get; set; }

        [Required]
        public DateTime UltimaModificación { get; set; }

        [Required]
        public int RolID { get; set; }
    }
}
