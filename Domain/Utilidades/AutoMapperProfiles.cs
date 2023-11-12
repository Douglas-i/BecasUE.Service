using AutoMapper;
using DataAccess.Entities;
using Domain.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Utilidades
{
    public class AutoMapperProfiles: Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<Universidad, UniversidadDTO>().ReverseMap();
            CreateMap<UniversidadCreacionDTO, Universidad>();            

        }
    }
}
