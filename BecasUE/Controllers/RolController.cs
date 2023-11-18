using Domain.DTOs;
using Domain;
using Microsoft.AspNetCore.Mvc;

namespace BecasUE.Controllers
{
    [Route("api/Rol")]
    public class RolController : Controller
    {
        private readonly ILogger<RolController> logger;
        private readonly RolEP rol;
        private readonly RolDTO rolDTO;

        public RolController(ILogger<RolController> logger, RolEP rol, RolDTO rolDTO)
        {
            this.logger = logger;
            this.rol = rol;
            this.rolDTO = rolDTO;
        }

        [HttpGet]
        public async Task<ActionResult<List<RolDTO>>> Get()
        {
            return await rol.Get();
        }

        [HttpPost]
        public async Task<ActionResult<string>> Post([FromBody] RolCDTO rolCDTO)
        {
            return await rol.Post(rolCDTO);
        }
    }
}
