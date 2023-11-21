using Domain.DTOs;
using Domain;
using Microsoft.AspNetCore.Mvc;

namespace BecasUE.Controllers
{
    [Route("api/OfertaAnual")]
    public class OfertaAnualController : Controller
    {
        private readonly ILogger<OfertaAnualController> logger;
        private readonly OfertaAnualEP ofertaAnual;
        private readonly OfertaAnualDTO ofertaAnualDTO;

        public OfertaAnualController(ILogger<OfertaAnualController> logger, OfertaAnualEP ofertaAnual, OfertaAnualDTO ofertaAnualDTO)
        {
            this.logger = logger;
            this.ofertaAnual = ofertaAnual;
            this.ofertaAnualDTO = ofertaAnualDTO;
        }

        [HttpGet]
        public async Task<ActionResult<List<OfertaAnualDTO>>> Get()
        {
            return await ofertaAnual.Get();
        }


        [HttpGet("{Id:int}")]
        public async Task<ActionResult<OfertaAnualDTO>> Get_Id(int Id)
        {
            return await ofertaAnual.Get_Id(Id);
        }

        [HttpPost]
        public async Task<ActionResult<string>> Post([FromBody] OfertaAnualCDTO ofertaAnualCDTO)
        {
            return await ofertaAnual.Post(ofertaAnualCDTO);
        }

        [HttpPut("{Id:int}")]
        public async Task<ActionResult<string>> Put(int Id, [FromBody] OfertaAnualCDTO ofertaAnualCDTO)
        {
            return await ofertaAnual.Put(Id, ofertaAnualCDTO);
        }
    }
}
