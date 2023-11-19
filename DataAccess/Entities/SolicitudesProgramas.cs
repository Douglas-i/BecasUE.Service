using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DataAccess.Entities
{
    public class SolicitudesProgramas
    {
        [Key]
        public int SolicitudId { get; set; }
        public string Resumen { get; set; }
        public DateTime FechaSolicitud { get; set; }
        public string Estado { get; set; }
        
        //Relaciones
        public int PersonaId { get; set; }
        public Persona Persona { get; set; }
        public int ProgramaOfertadoId { get; set; }
        public ProgramasOfertados ProgramasOfertados { get; set; }
        public SolicitudesAceptadas SolicitudesAceptadas { get; set; }
    }
}
