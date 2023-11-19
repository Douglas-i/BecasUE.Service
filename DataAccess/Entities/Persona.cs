using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entities
{
    public class Persona
    {
        [Key]
        public int PersonaID { get; set; }
        [Required]
        [StringLength(maximumLength: 100)]
        public string NombrePersona { get; set; }
        [Required]
        [StringLength(maximumLength: 100)]
        public string ApellidoPersona { get; set; }
        [Required]
        [StringLength(maximumLength: 100)]
        public string PaísPrecedencia { get; set; }
        [Required]
        [StringLength(maximumLength: 100)]
        public string CorreoElectronico { get; set; }
        public string Pasaporte { get; set; }

        //--------------------------------------------Relaciones-----------------------------------//

        public Usuario Usuario { get; set; }

        // Relación uno a muchos con ProgramasTitulacion
        public List<ExperienciaLaboral> ExperienciaLaborals { get; set; }
        public List<EstudiosAcademicos> EstudiosAcademicos { get; set; }

        //Relacion uno a uno con Solicitudes Programadas
        public SolicitudesProgramas SolicitudesProgramas { get; set; }        
    }
}
