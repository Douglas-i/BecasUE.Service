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


        public async Task<TiposEspecialidadDTO> Get_Id(int Id)
        {
            var TiposEspecialidad = await context.TiposEspecialidad.FirstOrDefaultAsync(x => x.TipoEspecialidadID == Id);
            return mapper.Map<TiposEspecialidadDTO>(TiposEspecialidad);
        }
        public async Task<string> Post(TiposEspecialidadCDTO tiposEspecialidadCDTO)
        {
            var tipoespecialidad = mapper.Map<TiposEspecialidad>(tiposEspecialidadCDTO);
            context.Add(tipoespecialidad);
            await context.SaveChangesAsync();
            return "Tipo de Especialidad creada correctamente";
        }

        public async Task<string> Put(int Id, TiposEspecialidadCDTO tiposEspecialidadCDTO)
        {
            var tiposEspecialidad= await context.TiposEspecialidad.FirstOrDefaultAsync(x => x.TipoEspecialidadID == Id);
            tiposEspecialidad = mapper.Map(tiposEspecialidadCDTO, tiposEspecialidad);
            await context.SaveChangesAsync();
            return "Editado Correctamente";
        }
    }

}
