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
    public class EstudiosAcademicosEP
    {
        private readonly ApplicationDbContext context;
        private readonly IMapper mapper;

        public EstudiosAcademicosEP(ApplicationDbContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        public async Task<List<EstudiosAcademicosDTO>> Get()
        {
            var EstudiosAcademicos = await context.EstudiosAcademicos.ToListAsync();
            Console.WriteLine(EstudiosAcademicos);
            return mapper.Map<List<EstudiosAcademicosDTO>>(EstudiosAcademicos);
        }

        public async Task<string> Post(EstudiosAcademicosCDTO estudiosAcademicosCDTO)
        {
            var estudiosAcademicos = mapper.Map<EstudiosAcademicos>(estudiosAcademicosCDTO);
            context.Add(estudiosAcademicos);
            await context.SaveChangesAsync();
            return "Creado Correctamente";
        }
    }
}
