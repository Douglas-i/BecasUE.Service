using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DTOs
{
    public class EstudiosAcademicosDTO
    {
        public int EntidadEmisora { get; set; }
        public DateTime FechaFinalizacion { get; set; }
        public DateTime FechaInicio { get; set; }
        public string TituloObtenido { get; set; }
       
    }
}
