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
    public class OfertaAnualEP
    {
        private readonly ApplicationDbContext context;
        private readonly IMapper mapper;

        public OfertaAnualEP(ApplicationDbContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        public async Task<List<OfertaAnualDTO>> Get()
        {
            var ofertaanual = await context.OfertaAnual.ToListAsync();
            Console.WriteLine(ofertaanual);
            return mapper.Map<List<OfertaAnualDTO>>(ofertaanual);
        }

        public async Task<string> Post(OfertaAnualCDTO ofertaAnualCDTO)
        {
            var ofertaanual = mapper.Map<OfertaAnual>(ofertaAnualCDTO);
            context.Add(ofertaanual);
            await context.SaveChangesAsync();
            return "Oferta Anual creada correctamente";
        }
    }
}
