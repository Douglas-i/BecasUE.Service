using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DTOs
{
    public class OfertaAnualCDTO
    {       
        [Required]
        public int Anio { get; set; }

        [Required]
        public DateTime FechaApertura { get; set; }

        [Required]
        public DateTime FechaCierre { get; set; }

        [Required]
        public DateTime FechaCreacion { get; set; }

        [Required]
        public int NumeroUniversidades { get; set; }

        [Required]
        [StringLength(maximumLength: 50)]
        public string Estado { get; set; }

        [Required]
        [StringLength(maximumLength: 100)]
        public string PaisSedePrograma { get; set; }
    }
}
