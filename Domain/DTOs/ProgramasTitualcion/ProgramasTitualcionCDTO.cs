using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DTOs.ProgramasTitualcion
{
    public class ProgramasTitualcionCDTO
    {
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
    }
}
