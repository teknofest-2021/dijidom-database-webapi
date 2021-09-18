using System.Collections.Generic;
using dijidom_database_webapi.Data;
using dijidom_database_webapi.Operations.MeasurementOperations.Command;
using dijidom_database_webapi.Operations.MeasurementOperations.Queries.GetAllMeasurementByPlantID;
using dijidom_database_webapi.Operations.MeasurementOperations.Queries.GetAllMeasurementDateByID;
using dijidom_database_webapi.Operations.MeasurementOperations.Queries.GetLastMeasurement;
using Microsoft.AspNetCore.Mvc;

namespace dijidom_database_webapi.Controllers
{
    [ApiController]
    [Route("api/[controller]s")]
    public class MeasurementController: ControllerBase
    {
        private readonly IDijiDomDBContext _dbContext;

        public MeasurementController(IDijiDomDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpPost("CreateMeasurement")]
        public IActionResult CreateMeasurement([FromBody] CreateMeasurementViewModel model)
        {
            CreateMeasurementCommand handler = new CreateMeasurementCommand(_dbContext);
            handler.Model = model;
            var result = handler.Handle();
            return Ok(result);
        }

        [HttpGet("GetLastMeasurement")]
        public ActionResult<List<GetLastMeasurementViewModel>> GetLastMeasurement()
        {
            GetLastMeasurementQuery handler = new GetLastMeasurementQuery(_dbContext);
            var result = handler.Handle();
            return Ok(result);
        }

        [HttpGet("GetAllMeasurementByPlantID")]
        public ActionResult<List<GetAllMeasurementByPlantIDViewModel>> GetAllMeasurementByPlantID(int plantID)
        {
            GetAllMeasurementByPlantIDQuery handler = new GetAllMeasurementByPlantIDQuery(_dbContext);
            handler.PlantID = plantID;
            var result = handler.Handle();
            return Ok(result);
        }


        [HttpPost("GetAllMeasurementDateByIDQuery")]
        public ActionResult<List<GetAllMeasurementByPlantIDViewModel>> GetAllMeasurementDateByIDQuery(GetAllMeasurementDateByIDQueryModel model)
        {
            GetAllMeasurementDateByIDQuery handler = new GetAllMeasurementDateByIDQuery(_dbContext);
            handler.Model = model;
            return Ok(handler.Handle());
        }
    }
}