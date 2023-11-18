using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DTOs
{
    public class OfertaAnualDTO
    {
        public int OfertaID { get; set; }

        public int Año { get; set; }

        public DateTime FechaApertura { get; set; }

        public DateTime FechaCierre { get; set; }

        public DateTime FechaCreacion { get; set; }

        public int NumeroUniversidades { get; set; }

        public string Estado { get; set; }

        public string PaisSedePrograma { get; set; }
    }
}
