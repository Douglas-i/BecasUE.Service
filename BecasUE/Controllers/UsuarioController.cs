using Domain.DTOs;
using Domain;
using Microsoft.AspNetCore.Mvc;
using DataAccess.Entities;

namespace BecasUE.Controllers
{
    [Route("api/Usuario")]
    public class UsuarioController : Controller
    {
        private readonly ILogger<UsuarioController> logger;
        private readonly UsuarioEP usuario;
        private readonly UsuarioDTO usuarioDTO;

        public UsuarioController(ILogger<UsuarioController> logger, UsuarioEP usuario, UsuarioDTO usuarioDTO)
        {
            this.logger = logger;
            this.usuario = usuario;
            this.usuarioDTO = usuarioDTO;
        }

        [HttpGet]
        public async Task<ActionResult<List<UsuarioDTO>>> Get()
        {
            return await usuario.Get();
        }

        [HttpGet("{Id:int}")]
        public async Task<ActionResult<UsuarioDTO>> Get_Id(int Id)
        {
            return await usuario.Get_Id(Id);
        }

        [HttpPost]
        public async Task<ActionResult<string>> Post([FromBody] UsuarioCDTO usuarioCDTO)
        {
            return await usuario.Post(usuarioCDTO);
        }

        [HttpPut("{Id:int}")]
        public async Task<ActionResult<string>> Put(int Id, [FromBody] UsuarioCDTO usuarioCDTO)
        {
            return await usuario.Put(Id, usuarioCDTO);
        }
    }
}
