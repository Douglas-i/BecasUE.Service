using AutoMapper;
using DataAccess.Entities;
using DataAccess;
using Domain.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class PersonaEP
    {
        private readonly ApplicationDbContext context;
        private readonly IMapper mapper;

        public PersonaEP(ApplicationDbContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        public async Task<List<PersonaDTO>> Get()
        {
            var persona = await context.Persona.ToListAsync();
            Console.WriteLine(persona);
            return mapper.Map<List<PersonaDTO>>(persona);
        }

        public async Task<string> Post(PersonaCDTO personaCDTO)
        {
            var persona = mapper.Map<Persona>(personaCDTO);
            context.Add(persona);
            await context.SaveChangesAsync();
            return "Persona creada correctamente";
        }
    }
}
