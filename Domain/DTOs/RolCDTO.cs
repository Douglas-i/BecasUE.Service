using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DTOs
{
    public class RolCDTO
    {
        [Required]
        [StringLength(maximumLength: 100)]
        public string NombreRol { get; set; }
    }
}
