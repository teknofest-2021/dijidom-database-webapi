using System;
using System.Collections.Generic;
using dijidom_database_webapi.Data;
using dijidom_database_webapi.Models;
using dijidom_database_webapi.Operations.PlantOperations.Command;
using dijidom_database_webapi.Operations.PlantOperations.Queries;
using Microsoft.AspNetCore.Mvc;

namespace dijidom_database_webapi.Controllers
{
    [ApiController]
    [Route("api/[controller]s")]
    public class PlantController : ControllerBase
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

        [HttpPost("UpdatePlantHeight")]
        public ActionResult<Plant> UpdatePlantHeight(int plantID, Single plantHeight)
        {
            UpdatePlantHeightCommand handler = new UpdatePlantHeightCommand(_dbContext);
            handler.PlantID = plantID;
            handler.PlantHeight = plantHeight;
            return Ok(handler.Handle());
        }

        [HttpPost("CreatePlant")]
        public ActionResult<Plant> CreatePlant([FromBody] CreatePlantViewModel plant)
        {
            CreatePlantCommand handler = new CreatePlantCommand(_dbContext);
            handler.Model = plant;
            return Ok(handler.Handle());
        }
    }
}