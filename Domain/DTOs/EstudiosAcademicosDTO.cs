using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DTOs
{
    public class EstudiosAcademicosDTO
    {        
        public int EstudiosAcademicosId { get; set; }

        public string TituloObtenido { get; set; }
               
        public string EntidadEmisora { get; set; }
              
        public DateTime FechaInicio { get; set; }
        
        public DateTime FechaFinalizacion { get; set; }

        public int CandidatoID { get; set; }
    }
}
