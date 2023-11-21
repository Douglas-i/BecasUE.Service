using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DTOs.ProgramasOfertados
{
    public class ProgramasOfertadosDTO
    {        
        public int ProgramaOfertadoId { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFinalazacion { get; set; }
        public decimal MontoAprobado { get; set; }
        public int Financiamiento { get; set; }
        public List<ProgramasTitulacion> ProgramasTitualcion { get; set; }
        public List<OfertaAnual> OfertaAnual { get; set; }
        public List<Universidad> Universidad { get; set; }        
    }
}
