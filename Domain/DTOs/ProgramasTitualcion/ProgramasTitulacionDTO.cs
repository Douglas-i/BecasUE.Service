using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DTOs.Relaciones
{
    public class ProgramasTitulacionDTO
    {
        public int ProgramaId { get; set; }
        public string TituloPrograma { get; set; }
        public int CantidadCredito { get; set; }
        public int NumeroDiplomados { get; set; }
        public string Duracion { get; set; }
        public List<TiposEspecialidadDTO> Especialidades {get; set;}
    }
}
