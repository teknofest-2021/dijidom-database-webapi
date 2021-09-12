using System.Collections.Generic;
using dijidom_database_webapi.Data;
using dijidom_database_webapi.Models;
using dijidom_database_webapi.Operations.SoilOperations.Queries;
using Microsoft.AspNetCore.Mvc;

namespace dijidom_database_webapi.Controllers
{
    [ApiController]
    [Route("api/[controller]s")]
    public class SoilController : ControllerBase
    {
        private readonly IDijiDomDBContext _dbContext;

        public SoilController(IDijiDomDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet("GetSoils")]
        public ActionResult<List<Soil>> GetPlants()
        {
            SoilGetAllQuery handler = new SoilGetAllQuery(_dbContext);
            var result = handler.Handle();
            return Ok(result);
        }
    }
}