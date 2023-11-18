using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DTOs
{
    public class UsuarioDTO
    {
        public int UsuarioID { get; set; }

        public string NombreUsuario { get; set; }

        public string Contraseña { get; set; }

        public DateTime FechaCreación { get; set; }

        public DateTime UltimaModificación { get; set; }

        public int RolID { get; set; }
    }
}
