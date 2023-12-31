﻿using DataAccess;
using DataAccess.Entities;
using Domain.DTOs;
using Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace BecasUE.Controllers
{
    [Route("api/Persona")]
    public class PersonaController : Controller
    {
        private readonly ILogger<PersonaController> logger;
        private readonly PersonaEP persona;
        private readonly PersonaDTO personaDTO;

        public PersonaController(ILogger<PersonaController> logger, PersonaEP persona, PersonaDTO personaDTO)
        {
            this.logger = logger;
            this.persona = persona;
            this.personaDTO = personaDTO;
        }

        [HttpGet]
        public async Task<ActionResult<List<PersonaDTO>>> Get()
        {
            return await persona.Get();
        }

        [HttpGet("{Id:int}")]
        public async Task<ActionResult<PersonaDTO>> Get_Id(int Id)
        {
            return await persona.Get_Id(Id);
        }

        [HttpPost]
        public async Task<ActionResult<string>> Post([FromBody] PersonaCDTO personaCDTO)
        {
            return await persona.Post(personaCDTO);
        }

        [HttpPut("{Id:int}")]
        public async Task<ActionResult<string>> Put(int Id, [FromBody] PersonaCDTO personaCDTO)
        {
            return await persona.Put(Id, personaCDTO);
        }
    }
}
