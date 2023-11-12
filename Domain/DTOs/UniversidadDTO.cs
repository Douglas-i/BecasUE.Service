using AutoMapper;
using DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DTOs
{
    public class UniversidadDTO
    {
        public int universidadId { get; set; }
        public string universidadNombre { get; set; }
        public string pais { get; set; }
        public string ciudad { get; set; }
        public string direccion { get; set; }
        public string telefono { get; set; }
       
    }
}
