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
    public class RolEP
    {
        private readonly ApplicationDbContext context;
        private readonly IMapper mapper;

        public RolEP(ApplicationDbContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        public async Task<List<RolDTO>> Get()
        {
            var rol = await context.Rol.ToListAsync();
            Console.WriteLine(rol);
            return mapper.Map<List<RolDTO>>(rol);
        }

        public async Task<string> Post(RolCDTO rolCDTO)
        {
            var rol = mapper.Map<Rol>(rolCDTO);
            context.Add(rol);
            await context.SaveChangesAsync();
            return "Rol creado correctamente";
        }
    }
}
