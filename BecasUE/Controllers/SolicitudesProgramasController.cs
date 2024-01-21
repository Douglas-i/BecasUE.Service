using Domain.DTOs.ProgramasOfertados;
using Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Domain.DTOs.SolicitudesProgramas;

namespace BecasUE.Controllers
{
    [Route("api/SolicitudesProgramas")]
    public class SolicitudesProgramasController : Controller
    {
        //private readonly ILogger<EstudiosAcademicosController> logger;
        private readonly SolicitudesProgramasEP solicitudesProgramas;
        private readonly SolicitudesProgramasDTO solicitudesProgramasDTO;
        //private readonly ApplicationDbContext context;

        public SolicitudesProgramasController(SolicitudesProgramasDTO solicitudesProgramasDTO, SolicitudesProgramasEP solicitudesProgramas)
        {
            this.solicitudesProgramasDTO = solicitudesProgramasDTO;
            this.solicitudesProgramas = solicitudesProgramas;
        }

        [HttpGet]
        public async Task<ActionResult<List<SolicitudesProgramasDTO>>> Get()
        {
            return await solicitudesProgramas.Get();
        }

        [HttpPost]
        public async Task<ActionResult<string>> Post([FromBody] SolicitudesProgramasCDTO solicitudesProgramasCDTO)
        {
            if (solicitudesProgramasCDTO == null)
            {
                return BadRequest("El objeto de estudiosAcademicosCDTO no puede ser nulo.");
            }

            return await solicitudesProgramas.Post(solicitudesProgramasCDTO);            
        }

        [HttpPut("{Id:int}")]
        public async Task<ActionResult<string>> Put(int Id, [FromBody] SolicitudesProgramasCDTO solicitudesProgramasCDTO)
        {
            return await solicitudesProgramas.Put(Id, solicitudesProgramasCDTO);
        }
    }
}
