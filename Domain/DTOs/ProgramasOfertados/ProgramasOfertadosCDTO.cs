using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DTOs.ProgramasOfertados
{
    public class ProgramasOfertadosCDTO
    {        
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFinalazacion { get; set; }
        public decimal MontoAprobado { get; set; }
        public int Financiamiento { get; set; }

        //Relaciones

        public int ProgramaId { get; set; }     
        public int OfertaId { get; set; }         
        public int UniversidadId { get; set; }        
    }
}
