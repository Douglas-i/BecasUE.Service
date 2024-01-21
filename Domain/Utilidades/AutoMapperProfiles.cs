using AutoMapper;
using DataAccess.Entities;
using Domain.DTOs;
using Domain.DTOs.ProgramasOfertados;
using Domain.DTOs.ProgramasTitualcion;
using Domain.DTOs.Relaciones;
using Domain.DTOs.SolicitudesProgramas;
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
            CreateMap<ProgramasTitulacion, ProgramasTitulacionDTO>()
                .ForMember(x => x.Especialidades, options => options.MapFrom(MapearProgramasTitualcionEspecialidad));
            CreateMap<ProgramasTitualcionCDTO, ProgramasTitulacion>();

            CreateMap<ProgramasOfertados, ProgramasOfertadosDTO>();                
                //.ForMember(x => x.ProgramasTitualcion, options => options.MapFrom(MapearProgramasOfertaPrograma))
                //.ForMember(X => X.Universidad, options => options.MapFrom(MapearProgramasOfertaUniversidad))
                //.ForMember(X => X.OfertaAnual, options => options.MapFrom(MapearProgramasOfertaAnual));
            CreateMap<ProgramasOfertadosCDTO, ProgramasOfertados>();

            CreateMap<SolicitudesProgramas, SolicitudesProgramasDTO>().ReverseMap();
            CreateMap<SolicitudesProgramasCDTO, SolicitudesProgramas>();
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

        private List<ProgramasTitulacionDTO> MapearProgramasOfertaPrograma(ProgramasOfertados programasOfertados, ProgramasOfertadosDTO programasOfertadosDTO)
        {
            var resultado = new List<ProgramasTitulacionDTO>();

            if (programasOfertados.Programas != null)
            {
                resultado.Add(new ProgramasTitulacionDTO() { ProgramaId = programasOfertados.Programas.ProgramaId, TituloPrograma = programasOfertados.Programas.TituloPrograma});
            }
            return resultado;
        }

        private List<UniversidadDTO> MapearProgramasOfertaUniversidad(ProgramasOfertados programasOfertados, ProgramasOfertadosDTO programasOfertadosDTO)
        {
            var resultado = new List<UniversidadDTO>();

            if (programasOfertados.Universidad != null)
            {
                resultado.Add(new UniversidadDTO() { universidadId = programasOfertados.Universidad.universidadId, universidadNombre = programasOfertados.Universidad.universidadNombre });
            }
            return resultado;
        }

        private List<OfertaAnualDTO> MapearProgramasOfertaAnual(ProgramasOfertados programasOfertados, ProgramasOfertadosDTO programasOfertadosDTO)
        {
            var resultado = new List<OfertaAnualDTO>();

            if (programasOfertados.Oferta != null)
            {
                resultado.Add(new OfertaAnualDTO() { OfertaID = programasOfertados.Oferta.OfertaID, FechaApertura = programasOfertados.Oferta.FechaApertura });
            }
            return resultado;
        }
    }
}
