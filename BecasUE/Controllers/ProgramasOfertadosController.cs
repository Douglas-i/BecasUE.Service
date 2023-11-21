using Domain.DTOs.ProgramasTitualcion;
using Domain.DTOs.Relaciones;
using Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Domain.DTOs.ProgramasOfertados;

namespace BecasUE.Controllers
{
    [Route("api/ProgramasOfertados")]
    public class ProgramasOfertadosController : Controller
    {
        //private readonly ILogger<EstudiosAcademicosController> logger;
        private readonly ProgramasOfertadosEP programasOfertados;
        private readonly ProgramasOfertadosDTO programasOfertadosDTO;
        //private readonly ApplicationDbContext context;

        public ProgramasOfertadosController(ProgramasOfertadosEP programasOfertados, ProgramasOfertadosDTO programasOfertadosDTO)
        {
            this.programasOfertados = programasOfertados;
            this.programasOfertadosDTO = programasOfertadosDTO;
        }

        [HttpGet]
        public async Task<ActionResult<List<ProgramasOfertadosDTO>>> Get()
        {
            return await programasOfertados.Get();
        }

        [HttpPost]
        public async Task<ActionResult<string>> Post([FromBody] ProgramasOfertadosCDTO programasOfertadosCDTO)
        {
            if (programasOfertadosCDTO == null)
            {
                return BadRequest("El objeto de estudiosAcademicosCDTO no puede ser nulo.");
            }

            return await programasOfertados.Post(programasOfertadosCDTO);
            //return await estudiosAcademicos.Post(estudiosAcademicosCDTO);
        }
    }
}
