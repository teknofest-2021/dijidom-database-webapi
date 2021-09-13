using System.Collections.Generic;
using dijidom_database_webapi.Data;
using dijidom_database_webapi.Operations.PlantOperations.Queries;
using Microsoft.AspNetCore.Mvc;

namespace dijidom_database_webapi.Controllers
{
    [ApiController]
    [Route("api/[controller]s")]
    public class PlantController: ControllerBase
    {
        private readonly IDijiDomDBContext _dbContext;

        public PlantController(IDijiDomDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet("GetPlants")]
        public ActionResult<List<GetAllPlantViewModel>> GetPlants()
        {
            GetAllPlantQuery handler = new GetAllPlantQuery(_dbContext);
            var result = handler.Handle();
            return Ok(result);
        }
    }
}