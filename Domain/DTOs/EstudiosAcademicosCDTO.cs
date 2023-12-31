﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DTOs
{
    public class EstudiosAcademicosCDTO
    {
        [Required]
        [StringLength(maximumLength: 1000)]
        public string TituloObtenido { get; set; }
        [Required]
        [StringLength(maximumLength: 1000)]
        public string EntidadEmisora { get; set; }
        [Required]
        public string FechaInicio { get; set; }
        [Required]
        public string FechaFinalizacion { get; set; }
        [Required]
        public int PersonaID { get; set; }
    }
}
