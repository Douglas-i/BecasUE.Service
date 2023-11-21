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

        public async Task<OfertaAnualDTO> Get_Id(int Id)
        {
            var ofertaAnual = await context.OfertaAnual.FirstOrDefaultAsync(x => x.OfertaID == Id);
            return mapper.Map<OfertaAnualDTO>(ofertaAnual);
        }

        public async Task<string> Post(OfertaAnualCDTO ofertaAnualCDTO)
        {
            var ofertaanual = mapper.Map<OfertaAnual>(ofertaAnualCDTO);
            context.Add(ofertaanual);
            await context.SaveChangesAsync();
            return "Oferta Anual creada correctamente";
        }
        public async Task<string> Put(int Id, OfertaAnualCDTO ofertaAnualCDTO)
        {
            var ofertaAnual = await context.OfertaAnual.FirstOrDefaultAsync(x => x.OfertaID == Id);
            ofertaAnual = mapper.Map(ofertaAnualCDTO, ofertaAnual);
            await context.SaveChangesAsync();
            return "Editado Correctamente";
        }
    }
}
