﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Domain.DTOs;
using Domain;

namespace BecasUE.Controllers
{
    [Route("api/Universidad")]
    public class UniversidadController : Controller
    {
        private readonly ILogger<UniversidadController> logger;
        private readonly UniversidadEndPoints universidad;
        private readonly UniversidadDTO universidadDTO;
        //private readonly ApplicationDbContext context;

        public UniversidadController(ILogger<UniversidadController> logger, UniversidadEndPoints universidad, UniversidadDTO universidadDTO)
        {
            this.logger = logger;
            this.universidad = universidad;
            this.universidadDTO = universidadDTO;
        }

        [HttpGet]
        public async Task<ActionResult<List<UniversidadDTO>>> Get()
        {
            return await universidad.Get();
        }

        [HttpGet("{Id:int}")]
        public async Task<ActionResult<UniversidadDTO>> Get_Id(int Id)
        {
            return await universidad.Get_Id(Id);
        }

        [HttpPost]
        public async Task<ActionResult<string>> Post([FromBody] UniversidadCreacionDTO universidadCreacionDTO)
        {
            return await universidad.Post(universidadCreacionDTO);
        }

        [HttpPut("{Id:int}")]
        public async Task<ActionResult<string>> Put(int Id, [FromBody] UniversidadCreacionDTO universidadCreacionDTO)
        {
            return await universidad.Put(Id, universidadCreacionDTO);
        }
    }
}
