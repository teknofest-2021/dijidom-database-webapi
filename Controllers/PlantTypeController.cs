using System.Collections.Generic;
using dijidom_database_webapi.Data;
using dijidom_database_webapi.Models;
using dijidom_database_webapi.Operations.PlantTypeOperations.Queries;
using Microsoft.AspNetCore.Mvc;

namespace dijidom_database_webapi.Controllers
{
    [ApiController]
    [Route("api/[controller]s")]
    public class PlantTypeController: ControllerBase
    {
        private readonly IDijiDomDBContext _dbContext;

        public PlantTypeController(IDijiDomDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet("GetPlantTypes")]
        public ActionResult<List<PlantType>> GetPlantTypes()
        {
            GetAllPlantTypeQuery handler = new GetAllPlantTypeQuery(_dbContext);
            var result = handler.Handle();
            return Ok(result);
        }
    }
}