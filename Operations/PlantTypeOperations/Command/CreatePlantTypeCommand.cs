using System;
using dijidom_database_webapi.Data;
using dijidom_database_webapi.Models;

namespace dijidom_database_webapi.Operations.PlantTypeOperations.Command
{
    public class CreatePlantTypeCommand
    {
        private readonly IDijiDomDBContext _dbContext;
        public CreatePlantTypeCommand(IDijiDomDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public string typeName { get; set; }
        public string Handle()
        {
            try
            {
                PlantType plantType = new PlantType()
                {
                    TypeName = typeName,
                };
                _dbContext.PlantTypes.Add(plantType);
                _dbContext.SaveChanges();
                return "Create successfully.";
            }
            catch (Exception)
            {
                return "Failed to create.";
            }
        }
    }
}