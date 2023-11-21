using DataAccess.Entities;
using DataAccess;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Domain.DTOs;
using Domain;

namespace BecasUE.Controllers
{
    [Route("api/TiposEspecialidad")]
    public class TiposEspecialidadController : Controller
    {
        private readonly ILogger<TiposEspecialidadController> logger;
        private readonly TiposEspecialidadEP tipoespecialidad;
        private readonly TiposEspecialidadDTO tipoespecialidadDTO;
        //private readonly ApplicationDbContext context;

        public TiposEspecialidadController(ILogger<TiposEspecialidadController> logger, TiposEspecialidadEP tipoespecialidad, TiposEspecialidadDTO tipoespecialidadDTO)
        {
            this.logger = logger;
            this.tipoespecialidad = tipoespecialidad;
            this.tipoespecialidadDTO = tipoespecialidadDTO;
        }

        [HttpGet]
        public async Task<ActionResult<List<TiposEspecialidadDTO>>> Get()
        {
            return await tipoespecialidad.Get();
        }

        [HttpGet("{Id:int}")]
        public async Task<ActionResult<TiposEspecialidadDTO>> Get_Id(int Id)
        {
            return await tipoespecialidad.Get_Id(Id);
        }


        [HttpPost]
        public async Task<ActionResult<string>> Post([FromBody] TiposEspecialidadCDTO tiposEspecialidadCDTO)
        {
            return await tipoespecialidad.Post(tiposEspecialidadCDTO);
        }

        [HttpPut("{Id:int}")]
        public async Task<ActionResult<string>> Put(int Id, [FromBody] TiposEspecialidadCDTO tiposEspecialidadCDTO)
        {
            return await tipoespecialidad.Put(Id, tiposEspecialidadCDTO);
        }
    }
}
