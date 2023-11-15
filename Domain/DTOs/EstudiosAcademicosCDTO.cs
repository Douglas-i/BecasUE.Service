using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DTOs
{
    public class EstudiosAcademicosCDTO
    {

        public int EntidadEmisora { get; set; }
        [Required]
        [StringLength(maximumLength: 100)]
        public DateTime FechaFinalizacion { get; set; }
        [Required]
        [StringLength(maximumLength: 100)]
        public DateTime FechaInicio { get; set; }
        [Required]
        [StringLength(maximumLength: 1000)]
        public string TituloObtenido { get; set; }
        [Required]
        [StringLength(maximumLength: 100)]
    }
}
