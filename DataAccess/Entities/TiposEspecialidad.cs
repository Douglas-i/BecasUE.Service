using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entities
{
    public class TiposEspecialidad
    {
        [Key]
        public int TipoEspecialidadID { get; set; }

        [Required]
        [StringLength(maximumLength: 100)]
        public string NombreTipoEspecialidad { get; set; }

        // Relación uno a muchos con ProgramasTitulacion
        public List<ProgramasTitulacion> ProgramasTitulaciones { get; set; }
    }

}
