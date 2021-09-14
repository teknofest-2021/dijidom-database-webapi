using System;
using System.Linq;
using dijidom_database_webapi.Data;
using dijidom_database_webapi.Models;

namespace dijidom_database_webapi.Operations.PlantOperations.Command
{
    public class UpdatePlantHeightCommand
    {
        private readonly IDijiDomDBContext _dbContext;

        public UpdatePlantHeightCommand(IDijiDomDBContext dbContext)
        {
            _dbContext = dbContext;
        }
        public int PlantID { get; set; }
        public Single PlantHeight { get; set; }
        public ResultModel<Plant> Handle()
        {
            if(PlantHeight < 0)
                return ResultModel<Plant>.GenerateResult(new Plant(), "Plant height cannot be less than 0.");
            try
            {
                Plant response = _dbContext.Plants.FirstOrDefault(p => p.PlantID == PlantID);
                response.PlantHeight = PlantHeight;
                _dbContext.SaveChanges();
                return ResultModel<Plant>.GenerateResult(response, "Updated successfully");
            }
            catch (Exception)
            {
                return ResultModel<Plant>.GenerateResult(new Plant(), "Update failed");
            }
        }
    }
}