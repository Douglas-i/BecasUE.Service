using AutoMapper;
using DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DTOs
{
    public class TiposEspecialidadDTO
    {
        public int TipoEspecialidadID { get; set; }

        public string NombreTipoEspecialidad { get; set; }
    }

}
