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

        public async Task<PersonaDTO> Get_Id(int Id)
        {
            var persona = await context.Persona.FirstOrDefaultAsync(x => x.PersonaID == Id);
            return mapper.Map<PersonaDTO>(persona);
        }

        public async Task<string> Post(PersonaCDTO personaCDTO)
        {
            var persona = mapper.Map<Persona>(personaCDTO);
            context.Add(persona);
            await context.SaveChangesAsync();
            return "Persona creada correctamente";
        }

        public async Task<string> Put(int Id, PersonaCDTO personaCDTO)
        {
            var persona = await context.Persona.FirstOrDefaultAsync(x => x.PersonaID == Id);
            persona = mapper.Map(personaCDTO, persona);
            await context.SaveChangesAsync();
            return "Editado Correctamente";
        }
    }
}
