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
    public class ExperienciaLaboralEP
    {
        private readonly ApplicationDbContext context;
        private readonly IMapper mapper;

        public ExperienciaLaboralEP(ApplicationDbContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        public async Task<List<ExperienciaLaboralDTO>> Get()
        {
            var universidad = await context.ExperienciaLaboral.ToListAsync();
            Console.WriteLine(universidad);
            return mapper.Map<List<ExperienciaLaboralDTO>>(universidad);
        }

        public async Task<string> Post(ExperienciaLaboralCDTO experienciaLaboralCDTO)
        {
            var universidad = mapper.Map<ExperienciaLaboral>(experienciaLaboralCDTO);
            context.Add(universidad);
            await context.SaveChangesAsync();
            return "Creado Correctamente";
        }
    }
}
