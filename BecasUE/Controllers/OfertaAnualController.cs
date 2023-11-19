using Domain.DTOs;
using Domain;
using Microsoft.AspNetCore.Mvc;

namespace BecasUE.Controllers
{
    [Route("api/OfertaAnual")]
    public class OfertaAnualController : Controller
    {
        private readonly ILogger<OfertaAnualController> logger;
        private readonly OfertaAnualEP ofertaanula;
        private readonly OfertaAnualDTO ofertaAnualDTO;

        public OfertaAnualController(ILogger<OfertaAnualController> logger, OfertaAnualEP ofertaAnual, OfertaAnualDTO ofertaAnualDTO)
        {
            this.logger = logger;
            this.ofertaanula = ofertaAnual;
            this.ofertaAnualDTO = ofertaAnualDTO;
        }

        [HttpGet]
        public async Task<ActionResult<List<OfertaAnualDTO>>> Get()
        {
            return await ofertaanula.Get();
        }

        [HttpPost]
        public async Task<ActionResult<string>> Post([FromBody] OfertaAnualCDTO ofertaAnualCDTO)
        {
            return await ofertaanula.Post(ofertaAnualCDTO);
        }
    }
}
