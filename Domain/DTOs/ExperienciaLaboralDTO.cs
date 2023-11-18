using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DTOs
{
    public class ExperienciaLaboralDTO
    {       
        public int ExperienciaLaboralID { get; set; }

        public string Puesto { get; set; }
              
        public string EntidadTrabajo { get; set; }
                
        public DateTime FechaInicio { get; set; }
        
        public DateTime FechaFinalizacion { get; set; }
               
        public int PersonaID { get; set; }
    }
}
