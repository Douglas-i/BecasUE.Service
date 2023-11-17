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

        [Required] 
        [StringLength(maximumLength: 100)] 
        public string Puesto{ get; set; }

        [Required]
        [StringLength(maximumLength: 100)]
        public string EntidadTrabajo{ get; set; }

        [Required]
        public DateTime FechaInicio { get; set; }

        [Required]
        public DateTime FechaFinalizacion { get; set; }

        [Required]
        public int CandidatoID { get; set; }     
    }
}
