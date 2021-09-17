using System;
using dijidom_database_webapi.Data;
using dijidom_database_webapi.Models;

namespace dijidom_database_webapi.Operations.PlantOperations.Command
{
    public class CreatePlantCommand
    {
        private readonly IDijiDomDBContext _dbContext;

        public CreatePlantCommand(IDijiDomDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public CreatePlantViewModel Model { get; set; }
        public ResultModel<CreatePlantViewModel> Handle()
        {
            try
            {
                Plant plant = new Plant()
                {
                    PlantName = Model.PlantName,
                    TypeID = Model.TypeID,
                    SowingDate = Model.SowingDate,
                };
                _dbContext.Plants.Add(plant);
                _dbContext.SaveChanges();
                return ResultModel<CreatePlantViewModel>.GenerateResult(Model, "Create successfully.");
            }
            catch (Exception)
            {
                return ResultModel<CreatePlantViewModel>.GenerateResult(new CreatePlantViewModel(), "Failed to create.");
            }
        }
    }
}