using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DTOs
{
    public class ExperienciaLaboralCDTO
    {
        public int EperienciaLaboralID { get; set; }
        [Required] 
        [StringLength(maximumLength: 100)] 
        public string Puesto { get; set; }
        [Required]
        [StringLength(maximumLength: 100)]
        public string EntidadTrabajo { get; set; }
        [StringLength(maximumLength: 1000)]
        public DateTime FechaInicio { get; set; }
        [StringLength(maximumLength: 50)]
        public DateTime FechaFinalizacion { get; set; }
        [StringLength(maximumLength: 50)]
        public string CandidatoID { get; set; }
        [Required]
        [StringLength(maximumLength: 100)]
    }
}
