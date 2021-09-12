using System.Collections.Generic;
using dijidom_database_webapi.Data;
using dijidom_database_webapi.Operations.MeasurementOperations.Command;
using dijidom_database_webapi.Operations.MeasurementOperations.Queries.MesurementGetAllByPlantID;
using dijidom_database_webapi.Operations.MeasurementOperations.Queries.MesurementGetLast;
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

        [HttpPost("MeasurementCreate")]
        public IActionResult MeasurementCreate([FromBody] MeasurementCreateViewModel model)
        {
            MeasurementCreateCommand handler = new MeasurementCreateCommand(_dbContext);
            handler.Model = model;
            var result = handler.Handle();
            return Ok(result);
        }

        [HttpGet("GetMeasurementLast")]
        public ActionResult<List<MesurementGetLastViewModel>> GetMeasurementLast()
        {
            MesurementGetLastQuery handler = new MesurementGetLastQuery(_dbContext);
            var result = handler.Handle();
            return Ok(result);
        }

        [HttpGet("MesurementGetAllByPlantID")]
        public ActionResult<List<MesurementGetLastViewModel>> MesurementGetAllByPlantID(int plantID)
        {
            MesurementGetAllByPlantIDQuery handler = new MesurementGetAllByPlantIDQuery(_dbContext);
            handler.PlantID = plantID;
            var result = handler.Handle();
            return Ok(result);
        }
    }
}