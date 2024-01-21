using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DTOs
{
    public class PersonaDTO
    {
        public int PersonaID { get; set; }

        public string NombrePersona { get; set; }

        public string ApellidoPersona { get; set; }

        public string PaisPrecedencia { get; set; }

        public string CorreoElectronico { get; set; }

        public string Pasaporte { get; set; }

        public int UsuarioID { get; set; }
    }
}
