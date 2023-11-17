using AutoMapper;
using DataAccess;
using DataAccess.Entities;
using Domain.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class TiposEspecialidadEP
    {
        private readonly ApplicationDbContext context;
        private readonly IMapper mapper;

        public TiposEspecialidadEP(ApplicationDbContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        public async Task<List<TiposEspecialidadDTO>> Get()
        {
            var tipoespecialidad = await context.TiposEspecialidad.ToListAsync();
            Console.WriteLine(tipoespecialidad);
            return mapper.Map<List<TiposEspecialidadDTO>>(tipoespecialidad);
        }

        public async Task<string> Post(TiposEspecialidadCDTO tiposEspecialidadCDTO)
        {
            var tipoespecialidad = mapper.Map<TiposEspecialidad>(tiposEspecialidadCDTO);
            context.Add(tipoespecialidad);
            await context.SaveChangesAsync();
            return "Tipo de Especialidad creada correctamente";
        }
    }

}
