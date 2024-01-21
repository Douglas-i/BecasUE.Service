using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DTOs.SolicitudesProgramas
{
    public class SolicitudesProgramasDTO
    {
        public int SolicitudId { get; set; }
        public string Resumen { get; set; }
        public DateTime FechaSolicitud { get; set; }
        public string Estado { get; set; }
        public int PersonaId { get; set; }
        public int ProgramaOfertadoId { get; set; }
    }
}
