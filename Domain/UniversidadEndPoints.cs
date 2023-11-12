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
            Console.WriteLine(universidad);
            return mapper.Map<List<UniversidadDTO>>(universidad);
        }

        public async Task<string> Post(UniversidadCreacionDTO universidadCreacionDTO)
        {
            var universidad = mapper.Map<Universidad>(universidadCreacionDTO);
            context.Add(universidad);
            await context.SaveChangesAsync();
            return "Creado Correctamente";
        }

    }
}
