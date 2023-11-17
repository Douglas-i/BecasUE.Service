﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DTOs
{
    public class SolicitudesAceptadasCDTO
    {   
        [Required]
        public int SolicitudID { get; set; }

        [Required]
        public DateTime FechaAceptacion { get; set; }
    }

}
