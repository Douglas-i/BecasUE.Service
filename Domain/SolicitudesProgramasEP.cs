using AutoMapper;
using DataAccess.Entities;
using DataAccess;
using Domain.DTOs.ProgramasOfertados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Domain.DTOs.SolicitudesProgramas;

namespace Domain
{
    public class SolicitudesProgramasEP
    {
        private readonly ApplicationDbContext context;
        private readonly IMapper mapper;

        public SolicitudesProgramasEP(ApplicationDbContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        public async Task<List<SolicitudesProgramasDTO>> Get()
        {
            var solicitudesProgramas = await context.SolicitudesProgramas.ToListAsync();
            return mapper.Map<List<SolicitudesProgramasDTO>>(solicitudesProgramas);
        }

        public async Task<string> Post(SolicitudesProgramasCDTO solicitudesProgramasCDTO)
        {
            var solicitudesProgramas = mapper.Map<SolicitudesProgramas>(solicitudesProgramasCDTO);
            context.Add(solicitudesProgramas);
            await context.SaveChangesAsync();
            return "Programa de TItualacion creado Correctamente";
        }
    }
}
