using AutoMapper;
using DataAccess.Entities;
using DataAccess;
using Domain.DTOs.ProgramasTitualcion;
using Domain.DTOs.Relaciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.DTOs.ProgramasOfertados;
using Microsoft.EntityFrameworkCore;

namespace Domain
{
    public class ProgramasOfertadosEP
    {
        private readonly ApplicationDbContext context;
        private readonly IMapper mapper;

        public ProgramasOfertadosEP(ApplicationDbContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        public async Task<List<ProgramasOfertadosDTO>> Get()
        {
            var programasOfertados = await context.ProgramasOfertados                                                
                                                .Include(x => x.Universidad)
                                                //.Include(p => p.Programas).ThenInclude(e => e.Especialidad)
                                                .Include(o => o.Oferta)                                                
                                                .ToArrayAsync();
            return mapper.Map<List<ProgramasOfertadosDTO>>(programasOfertados);
        }

        public async Task<string> Post(ProgramasOfertadosCDTO programasOfertadosCDTO)
        {
            var programasOfertados = mapper.Map<ProgramasOfertados>(programasOfertadosCDTO);
            context.Add(programasOfertados);
            await context.SaveChangesAsync();
            return "Programa de TItualacion creado Correctamente";
        }
    }
}
