using DataAccess;
using DataAccess.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace BecasUE.Controllers
{
    [Route("api/candidatos")]
    public class CandidatoController : Controller
    {        
        private readonly ILogger<CandidatoController> logger;

        public CandidatoController(ILogger<CandidatoController> logger/*, ApplicationDbContext context*/)
        {            
            this.logger = logger;
        }
    }
}
