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
    public class UsuarioEP
    {
        private readonly ApplicationDbContext context;
        private readonly IMapper mapper;

        public UsuarioEP(ApplicationDbContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        public async Task<List<UsuarioDTO>> Get()
        {
            var usuario = await context.Usuario.ToListAsync();
            Console.WriteLine(usuario);
            return mapper.Map<List<UsuarioDTO>>(usuario);
        }

        public async Task<UsuarioDTO> Get_Id(int Id)
        {
            var usuario = await context.Usuario.FirstOrDefaultAsync(x => x.UsuarioID == Id);
            return mapper.Map<UsuarioDTO>(usuario);
        }

        public async Task<string> Post(UsuarioCDTO usuarioCDTO)
        {
            var usuario = mapper.Map<Usuario>(usuarioCDTO);
            context.Add(usuario);
            await context.SaveChangesAsync();
            return "Usuario creado correctamente";
        }

        public async Task<string> Put(int Id, UsuarioCDTO usuarioCDTO)
        {
            var usuario = await context.Usuario.FirstOrDefaultAsync(x => x.UsuarioID == Id);
            usuario = mapper.Map(usuarioCDTO, usuario);
            await context.SaveChangesAsync();
            return "Editado Correctamente";
        }
    }
}
