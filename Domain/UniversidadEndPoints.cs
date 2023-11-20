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
    public class UniversidadEndPoints
    {
        private readonly ApplicationDbContext context;
        private readonly IMapper mapper;

        public UniversidadEndPoints(ApplicationDbContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        public async Task<List<UniversidadDTO>> Get()
        {
            var universidad = await context.Universidad.ToListAsync();            
            return mapper.Map<List<UniversidadDTO>>(universidad);
        }

        public async Task<UniversidadDTO> Get_Id(int Id)
        {
            var universidad = await context.Universidad.FirstOrDefaultAsync(x => x.universidadId == Id);         
            return mapper.Map<UniversidadDTO>(universidad);
        }

        public async Task<string> Post(UniversidadCreacionDTO universidadCreacionDTO)
        {
            var universidad = mapper.Map<Universidad>(universidadCreacionDTO);
            context.Add(universidad);
            await context.SaveChangesAsync();
            return "Creado Correctamente";
        }

        public async Task<string> Put(int Id, UniversidadCreacionDTO universidadCreacionDTO)
        {
            var universidad = await context.Universidad.FirstOrDefaultAsync(x => x.universidadId == Id);
            universidad = mapper.Map(universidadCreacionDTO, universidad);
            await context.SaveChangesAsync();
            return "Editado Correctamente";
        }

    }
}
