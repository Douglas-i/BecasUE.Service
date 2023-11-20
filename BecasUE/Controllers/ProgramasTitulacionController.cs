using Domain.DTOs;
using Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Domain.DTOs.Relaciones;
using Domain.DTOs.ProgramasTitualcion;

namespace BecasUE.Controllers
{
    [Route("api/ProgramasTitulacion")]
    public class ProgramasTitulacionController : Controller
    {
        private readonly ILogger<EstudiosAcademicosController> logger;
        private readonly ProgramasTitulacionEP programasTitulacion;
        private readonly ProgramasTitulacionDTO programasTitulacionDTO;
        //private readonly ApplicationDbContext context;

        public ProgramasTitulacionController(ILogger<EstudiosAcademicosController> logger, ProgramasTitulacionEP programasTitulacion, ProgramasTitulacionDTO programasTitulacionDTO)
        {
            this.logger = logger;
            this.programasTitulacion = programasTitulacion;
            this.programasTitulacionDTO = programasTitulacionDTO;
        }

        [HttpGet]
        public async Task<ActionResult<List<ProgramasTitulacionDTO>>> Get()
        {
            return await programasTitulacion.Get();
        }

        [HttpGet("{Id:int}")]
        public async Task<ActionResult<ProgramasTitulacionDTO>> Get_Id(int Id)
        {
            return await programasTitulacion.Get_Id(Id);
        }

        [HttpPost]
        public async Task<ActionResult<string>> Post([FromBody] ProgramasTitualcionCDTO programasTitualcionCDTO)
        {
            if (programasTitualcionCDTO == null)
            {
                return BadRequest("El objeto de estudiosAcademicosCDTO no puede ser nulo.");
            }

            return await programasTitulacion.Post(programasTitualcionCDTO);
            //return await estudiosAcademicos.Post(estudiosAcademicosCDTO);
        }

        [HttpPut("{Id:int}")]
        public async Task<ActionResult<string>> Put(int Id, [FromBody] ProgramasTitualcionCDTO programasTitualcionCDTO)
        {
            return await programasTitulacion.Put(Id, programasTitualcionCDTO);
        }
    }
}
