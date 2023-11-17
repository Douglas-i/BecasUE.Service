using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entities
{
    public class SolicitudesAceptadas
    {
        [Key]
        public int SolicitudAceptadaId { get; set; }
        [Required] 
        [StringLength(maximumLength: 100)] 
        public DateTime FechaAceptacion { get; set; }
        [Required]
        [StringLength(maximumLength: 50)]
        public int SolicitudID { get; set; }        
       
    }
}
