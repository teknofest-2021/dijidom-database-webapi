using System.Collections.Generic;
using System.Linq;
using dijidom_database_webapi.Data;
using dijidom_database_webapi.Models;

namespace dijidom_database_webapi.Operations.PlantOperations.Queries
{
    public class GetAllPlantQuery
    {
        private readonly IDijiDomDBContext _dbContext;

        public GetAllPlantQuery(IDijiDomDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<GetAllPlantViewModel> Handle()
        {
            var result = from plant in _dbContext.Plants
            join planttype in _dbContext.PlantTypes 
            on plant.TypeID equals planttype.TypeID
            select new GetAllPlantViewModel{
                PlantID = plant.PlantID,
                PlantName = plant.PlantName,
                TypeName = planttype.TypeName,
                PlantHeight = plant.PlantHeight
            };

            var data = result.ToList();
            if(data == null)
                data = new List<GetAllPlantViewModel>();
            return data;
        }
    }
}

