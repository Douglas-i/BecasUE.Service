using DataAccess.Entities;
using Domain;
using Domain.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BecasUE.Controllers
{

    [Route("api/EstudiosAcademicos")]
    public class EstudiosAcademicosController: Controller
    {
        private readonly ILogger<EstudiosAcademicosController> logger;
        private readonly EstudiosAcademicosEP  estudiosAcademicos;
        private readonly EstudiosAcademicosDTO estudiosAcademicosDTO;
        //private readonly ApplicationDbContext context;

        public EstudiosAcademicosController(ILogger<EstudiosAcademicosController> logger, EstudiosAcademicosEP estudiosAcademicos, EstudiosAcademicosDTO estudiosAcademicosDTO)
        {
            this.logger = logger;
            this.estudiosAcademicos = estudiosAcademicos;
            this.estudiosAcademicosDTO = estudiosAcademicosDTO;
        }

        [HttpGet]
        public async Task<ActionResult<List<EstudiosAcademicosDTO>>> Get()
        {
            return await estudiosAcademicos.Get();
        }

        [HttpGet("{Id:int}")]
        public async Task<ActionResult<EstudiosAcademicosDTO>> Get_Id(int Id)
        {
            return await estudiosAcademicos.Get_Id(Id);
        }

        [HttpPost]
        public async Task<ActionResult<string>> Post([FromBody] EstudiosAcademicosCDTO estudiosAcademicosCDTO)
        {
            if (estudiosAcademicosCDTO == null)
            {
                return BadRequest("El objeto de estudiosAcademicosCDTO no puede ser nulo.");
            }

            // Validar el formato de las fechas sin modificar el objeto original
            if (!DateTime.TryParse(estudiosAcademicosCDTO.FechaFinalizacion, out _) ||
                !DateTime.TryParse(estudiosAcademicosCDTO.FechaInicio, out _))
            {
                return BadRequest("Formato de fecha incorrecto.");
            }

            return await estudiosAcademicos.Post(estudiosAcademicosCDTO);
            //return await estudiosAcademicos.Post(estudiosAcademicosCDTO);
        }

        [HttpPut("{Id:int}")]
        public async Task<ActionResult<string>> Put(int Id, [FromBody] EstudiosAcademicosCDTO estudiosAcademicosCDTO)
        {
            return await estudiosAcademicos.Put(Id, estudiosAcademicosCDTO);
        }
    }
}
