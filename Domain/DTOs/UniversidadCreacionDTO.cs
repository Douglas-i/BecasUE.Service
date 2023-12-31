﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DTOs
{
    public class UniversidadCreacionDTO
    {
        [Required] // Validacion para que este atributo sea requerrido
        [StringLength(maximumLength: 100)] // Validacion para el tamaño de archivo
        public string universidadNombre { get; set; }
        [Required]
        [StringLength(maximumLength: 50)]
        public string pais { get; set; }
        [StringLength(maximumLength: 50)]
        public string ciudad { get; set; }
        [StringLength(maximumLength: 100)]
        public string direccion { get; set; }
        [StringLength(maximumLength: 8)]
        public string telefono { get; set; }
    }
}
