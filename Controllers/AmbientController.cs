using System.Collections.Generic;
using dijidom_database_webapi.Data;
using dijidom_database_webapi.Models;
using dijidom_database_webapi.Operations.AmbientOperations.Queries;
using Microsoft.AspNetCore.Mvc;

namespace dijidom_database_webapi.Controllers
{
    [ApiController]
    [Route("api/[controller]s")]
    public class AmbientController: ControllerBase
    {
        private readonly IDijiDomDBContext _dbContext;

        public AmbientController(IDijiDomDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet("GetAmbients")]
        public ActionResult<List<GetAllAmbientViewModel>> GetAllAmbient()
        {
            GetAllAmbientQuery handler = new GetAllAmbientQuery(_dbContext);
            var result = handler.Handle();
            return Ok(result);
        }
    }
}