using Domain;
using Domain.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BecasUE.Controllers
{
    [Route("api/SolicitudesAceptadas")]
    public class SolicitudesAceptadasController : Controller
    {
        private readonly ILogger<SolicitudesAceptadasController> logger;
        private readonly SolicitudesAceptadasEP SolicitudesAceptadas;
        private readonly SolicitudesAceptadasDTO solicitudesAceptadasDTO;
        //private readonly ApplicationDbContext context;

        public SolicitudesAceptadasController(ILogger<SolicitudesAceptadasController> logger, SolicitudesAceptadasEP solicitudesAceptadas, SolicitudesAceptadasDTO solicitudesAceptadasDTO)
        {
            this.logger = logger;
            this.SolicitudesAceptadas = solicitudesAceptadas;
            this.solicitudesAceptadasDTO = solicitudesAceptadasDTO;
        }

        [HttpGet]
        public async Task<ActionResult<List<SolicitudesAceptadasDTO>>> Get()
        {
            return await SolicitudesAceptadas.Get();
        }

        [HttpPost]
        public async Task<ActionResult<string>> Post([FromBody] SolicitudesAceptadasCDTO solicitudesAceptadasCDTO)
        {
            if (solicitudesAceptadasCDTO == null)
            {
                return BadRequest("El objeto de solicitudesAceptadasCDTO no puede ser nulo.");
            }

            // Validar el formato de las fechas sin modificar el objeto original
            if (!DateTime.TryParse(solicitudesAceptadasCDTO.FechaAceptacion, out _))
            {
                return BadRequest("Formato de fecha incorrecto.");
            }

            return await SolicitudesAceptadas.Post(solicitudesAceptadasCDTO);
        }
    }
}
