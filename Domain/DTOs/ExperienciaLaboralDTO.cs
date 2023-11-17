﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DTOs
{
    public class ExperienciaLaboralDTO
    {
        public int EperienciaLaboralID { get; set; }
      
        public string Puesto { get; set; }
       
        public string EntidadTrabajo { get; set; }
     
        public DateTime FechaInicio { get; set; }
       
        public DateTime FechaFinalizacion { get; set; }
       
        public string CandidatoID { get; set; }
       
    }
}
