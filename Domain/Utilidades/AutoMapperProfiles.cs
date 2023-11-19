using AutoMapper;
using DataAccess.Entities;
using Domain.DTOs;
using Domain.DTOs.ProgramasTitualcion;
using Domain.DTOs.Relaciones;
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
            CreateMap<Rol, RolDTO>().ReverseMap();
            CreateMap<RolCDTO, Rol>();

            CreateMap<Usuario, UsuarioDTO>().ReverseMap();
            CreateMap<UsuarioCDTO, Usuario>();

            CreateMap<Persona, PersonaDTO>().ReverseMap();
            CreateMap<PersonaCDTO, Persona>();

            CreateMap<OfertaAnual, OfertaAnualDTO>().ReverseMap();
            CreateMap<OfertaAnualCDTO, OfertaAnual>();

            CreateMap<Universidad, UniversidadDTO>().ReverseMap();
            CreateMap<UniversidadCreacionDTO, Universidad>();

            CreateMap<ExperienciaLaboral, ExperienciaLaboralDTO>().ReverseMap();
            CreateMap<ExperienciaLaboralCDTO, ExperienciaLaboral>();

            CreateMap<EstudiosAcademicos, EstudiosAcademicosDTO>().ReverseMap();
            CreateMap<EstudiosAcademicosCDTO, EstudiosAcademicos>();

            CreateMap<SolicitudesAceptadas, SolicitudesAceptadasDTO>().ReverseMap();
            CreateMap<SolicitudesAceptadasCDTO, SolicitudesAceptadas>();

            CreateMap<TiposEspecialidad, TiposEspecialidadDTO>().ReverseMap();
            CreateMap<TiposEspecialidadCDTO, TiposEspecialidad>();

            //Relaciones
            CreateMap<ProgramasTitulacion, ProgramasTitulacionDTO>()/*.ReverseMap()*/
                .ForMember(x => x.Especialidades, options => options.MapFrom(MapearProgramasTitualcionEspecialidad));
            CreateMap<ProgramasTitualcionCDTO, ProgramasTitulacion>();
        }

        private List<TiposEspecialidadDTO> MapearProgramasTitualcionEspecialidad(ProgramasTitulacion programasTitulacion, ProgramasTitulacionDTO programasTitulacionDTO)
        {
            var resultado = new List<TiposEspecialidadDTO>();

            if (programasTitulacion.Especialidad != null)
            {
                resultado.Add(new TiposEspecialidadDTO() { TipoEspecialidadID = programasTitulacion.Especialidad.TipoEspecialidadID, NombreTipoEspecialidad = programasTitulacion.Especialidad.NombreTipoEspecialidad});
            }
            return resultado;
        }
    }
}
