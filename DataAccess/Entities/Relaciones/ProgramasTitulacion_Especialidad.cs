using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entities.Relaciones
{
    public class ProgramasTitulacion_Especialidad
    {
        public int ProgramaId { get; set; }
        public int EspecialidadId { get; set; }        

        //Propiedades de Navegación
        //public ProgramasTitulacion ProgramasTitulacion { get; set; }
        //public TiposEspecialidad TiposEspecialidad { get; set; }
    }
}
