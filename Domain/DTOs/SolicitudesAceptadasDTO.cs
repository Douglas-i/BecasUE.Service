using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DTOs
{
    public class SolicitudesAceptadasDTO
    {       
        public int SolicitudAceptadaId { get; set; }
                
        public int SolicitudID { get; set; }
               
        public DateTime FechaAceptacion { get; set; }
    }
}
