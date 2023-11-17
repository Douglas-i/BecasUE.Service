using DataAccess.Entities;
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

        [HttpPost]
        public async Task<ActionResult<string>> Post([FromBody] ExperienciaLaboralCDTO experienciaLaboralCDTO)
        {
            return await experienciaLaboral.Post(experienciaLaboralCDTO);
        }
    }
}
