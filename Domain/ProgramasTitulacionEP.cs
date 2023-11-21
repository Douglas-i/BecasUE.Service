﻿using AutoMapper;
using DataAccess.Entities;
using DataAccess;
using Domain.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.DTOs.Relaciones;
using Microsoft.EntityFrameworkCore;
using Domain.DTOs.ProgramasTitualcion;

namespace Domain
{
    public class ProgramasTitulacionEP
    {
        private readonly ApplicationDbContext context;
        private readonly IMapper mapper;

        public ProgramasTitulacionEP(ApplicationDbContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        public async Task<List<ProgramasTitulacionDTO>> Get()
        {
            var programasTItulacion = await context.ProgramasTitulacion
                                                .Include(x => x.Especialidad)
                                                .ToArrayAsync();
            return mapper.Map<List<ProgramasTitulacionDTO>>(programasTItulacion);
        }

        public async Task<ProgramasTitulacionDTO> Get_Id(int Id)
        {
            var programasTitulacion = await context.ProgramasTitulacion.FirstOrDefaultAsync(x => x.ProgramasId == Id);
            return mapper.Map<ProgramasTitulacionDTO>(programasTitulacion);
        }

        public async Task<string> Post(ProgramasTitualcionCDTO programasTitulacionCDTO)
        {
            var programasTitulacion = mapper.Map<ProgramasTitulacion>(programasTitulacionCDTO);
            context.Add(programasTitulacion);
            await context.SaveChangesAsync();
            return "Programa de TItualacion creado Correctamente";
        }


        public async Task<string> Put(int Id, ProgramasTitualcionCDTO programasTitualcionCDTO)
        {
            var programasTitulacion = await context.ProgramasTitulacion.FirstOrDefaultAsync(x => x.ProgramasId == Id);
            programasTitulacion = mapper.Map(programasTitualcionCDTO, programasTitulacion);
            await context.SaveChangesAsync();
            return "Editado Correctamente";
        }

    }
}
