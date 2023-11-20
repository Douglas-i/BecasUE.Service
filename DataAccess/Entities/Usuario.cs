using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entities
{
    public class Usuario
    {
        [Key]
        public int UsuarioID { get; set; }

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

        //--------------------------------------------Relaciones-----------------------------------//

        // Relación uno a uno con Persona        
        public int PersonaId { get; set; }
        public Persona Persona { get; set; }
    }
}
