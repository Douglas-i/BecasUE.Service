using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entities
{
    public class EstudiosAcademicos
    {
        [Key]
        public int EstudiosAcademicosID { get; set; }
        [Required]
        [StringLength(maximumLength: 1000)]
        public string TituloObtenido { get; set; }
        [Required]
        [StringLength(maximumLength: 1000)]
        public string EntidadEmisora { get; set; }
        [Required]
        public DateTime FechaInicio { get; set; }
        [Required]
        public DateTime FechaFinalizacion { get; set; }
        [Required]
        public int PersonaID { get; set; }

    }
}
