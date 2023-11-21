using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entities
{
    public class ProgramasTitulacion
    {
        [Key]
        [Required]
        public int ProgramaId { get; set; }
        [Required]
        [StringLength(maximumLength: 100)]
        public string TituloPrograma { get; set; }
        [Required]
        public int CantidadCredito { get; set; }
        public int NumeroDiplomados { get; set; }
        [StringLength(maximumLength: 100)]
        public string Duracion { get; set; }
        [Required]
        public int EspecialidadId { get; set; } // Clave foránea
        public TiposEspecialidad Especialidad { get; set; } // Propiedad de navegación

        // Relación uno a muchos con ProgramasTitulacion
        public List<ProgramasOfertados> ProgramasOfertados { get; set; }
    }
}
