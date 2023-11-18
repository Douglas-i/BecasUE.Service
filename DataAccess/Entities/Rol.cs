using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entities
{   
    public class Rol
    {
        [Key]
        public int RolID { get; set; }

        [Required]
        [StringLength(maximumLength: 100)]
        public string NombreRol { get; set; }

    }
}
