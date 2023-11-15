using System;
using System.Collections.Generic;
<<<<<<< HEAD
using System.ComponentModel.DataAnnotations;
=======
>>>>>>> df741315034c066a8a98a5d174ec0d6e2137e69a
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entities
{
    public class ExperienciaLaboral
    {
<<<<<<< HEAD
        public int EperienciaLaboralID { get; set; }
        [Required] // Validacion para que este atributo sea requerrido
        [StringLength(maximumLength: 100)] // Validacion para el tamaño de archivo
        public string Puesto{ get; set; }
        [Required]
        [StringLength(maximumLength: 100)]
        public string EntidadTrabajo{ get; set; }
        [StringLength(maximumLength: 1000)]
        public DateTime FechaInicio { get; set; }
        [StringLength(maximumLength: 50)]
        public DateTime FechaFinalizacion { get; set; }
        [StringLength(maximumLength: 50)]
        public string CandidatoID { get; set; }
        [Required]
        [StringLength(maximumLength: 100)]
        public static Task<Microsoft.AspNetCore.Mvc.ActionResult<string>> Post(global::Domain.DTOs.ExperienciaLaboralCDTO experiencaLaboralCDTO)
        {
            throw new NotImplementedException();
        }
=======
>>>>>>> df741315034c066a8a98a5d174ec0d6e2137e69a
    }
}
