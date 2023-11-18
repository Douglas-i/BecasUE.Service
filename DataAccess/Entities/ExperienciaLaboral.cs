using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entities
{
    public class ExperienciaLaboral
    {
        [Key]
        public int ExperienciaLaboralID { get; set; }
        [Required] // Validacion para que este atributo sea requerrido
        [StringLength(maximumLength: 100)] // Validacion para el tamaño de archivo
        public string Puesto { get; set; }
        [Required]
        [StringLength(maximumLength: 1000)]
        public string EntidadTrabajo { get; set; }
        [Required]
        public DateTime FechaInicio { get; set; }
        [Required]
        public DateTime FechaFinalizacion { get; set; }
        [Required]
        public int PersonaID { get; set; }
    }
}
