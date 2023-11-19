using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entities
{
    public class ProgramasOfertados
    {
        [Key]
        public int ProgramaOfertadoId { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFinalazacion { get; set; }
        public decimal MontoAprobado { get; set; }
        public int Financiamiento { get; set; }

        //Relaciones

        public int ProgramaId { get; set; } //Clave Foranea
        public ProgramasTitulacion Programas { get; set; } //Propiedad de Navegacion
        public int OfertaId { get; set; } //Clave Forane
        public OfertaAnual Oferta { get; set; } //Propiedad de Navegacion
        public int UniversidadId { get; set; } //Clave Foranea
        public Universidad Universidad { get; set; } // Propiedad de Navegacion
        public List<SolicitudesProgramas> SolicitudesProgramas { get; set; }

    }
}
