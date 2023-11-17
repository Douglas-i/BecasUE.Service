using AutoMapper;
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
    public class SolicitudesAceptadasEP
    {
        private readonly ApplicationDbContext context;
        private readonly IMapper mapper;

        public SolicitudesAceptadasEP(ApplicationDbContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        public async Task<List<SolicitudesAceptadasDTO>> Get()
        {
            var solicitudesAceptadas = await context.SolicitudesAceptadas.ToListAsync();
            Console.WriteLine(solicitudesAceptadas);
            return mapper.Map<List<SolicitudesAceptadasDTO>>(solicitudesAceptadas);
        }

        public async Task<string> Post(SolicitudesAceptadasCDTO solicitudesAceptadasCDTO)
        {
            var solicitudesAceptadas = mapper.Map<DataAccess.Entities.SolicitudesAceptadas>(solicitudesAceptadasCDTO);
            context.Add(solicitudesAceptadas);
            await context.SaveChangesAsync();
            return "Creado Correctamente";
        }

    }
}
