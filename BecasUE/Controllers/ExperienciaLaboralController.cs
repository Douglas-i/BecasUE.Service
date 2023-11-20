using DataAccess.Entities;
//using DataAccess.Migrations;
using Domain;
using Domain.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BecasUE.Controllers
{
    [Route("api/ExperienciaLaboral")]
    public class ExperienciaLaboralController : Controller
    {
        private readonly ILogger<ExperienciaLaboralController> logger;
        private readonly ExperienciaLaboralEP experienciaLaboral;
        private readonly ExperienciaLaboralDTO experienciaLaboralDTO;
        //private readonly ApplicationDbContext context;

        public ExperienciaLaboralController(ILogger<ExperienciaLaboralController> logger, ExperienciaLaboralEP experienciaLaboral, ExperienciaLaboralDTO experienciaLaboralDTO )
        {
            this.logger = logger;
            this.experienciaLaboral = experienciaLaboral;
            this.experienciaLaboralDTO = experienciaLaboralDTO;
        }

        [HttpGet]
        public async Task<ActionResult<List<ExperienciaLaboralDTO>>> Get()
        {
            return await experienciaLaboral.Get();
        }

        [HttpGet("{Id:int}")]
        public async Task<ActionResult<ExperienciaLaboralDTO>> Get_Id(int Id)
        {
            return await experienciaLaboral.Get_Id(Id);
        }

        [HttpPost]
        public async Task<ActionResult<string>> Post([FromBody] ExperienciaLaboralCDTO experienciaLaboralCDTO)
        {
            if (experienciaLaboralCDTO == null)
            {
                return BadRequest("El objeto de experienciaLaboralCDTO no puede ser nulo.");
            }

            // Validar el formato de las fechas sin modificar el objeto original
            if (!DateTime.TryParse(experienciaLaboralCDTO.FechaFinalizacion, out _) ||
                !DateTime.TryParse(experienciaLaboralCDTO.FechaInicio, out _))
            {
                return BadRequest("Formato de fecha incorrecto.");
            }

            return await experienciaLaboral.Post(experienciaLaboralCDTO);
            //return await experienciaLaboral.Post(experienciaLaboralCDTO);
        }

        [HttpPut("{Id:int}")]
        public async Task<ActionResult<string>> Put(int Id, [FromBody] ExperienciaLaboralCDTO experienciaLaboralCDTO)
        {
            return await experienciaLaboral.Put(Id, experienciaLaboralCDTO);
        }
    }
}
