using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entities
{
    public class OfertaAnual
    {
        [Key]
        public int OfertaID { get; set; }
        [Required]
        public int Año { get; set; }
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

        // Relación uno a muchos con ProgramasTitulacion
        public List<ProgramasOfertados> ProgramasOfertados { get; set; }
    }
}
