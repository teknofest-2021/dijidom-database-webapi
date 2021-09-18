using System.Collections.Generic;
using System.Linq;
using dijidom_database_webapi.Data;

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
            select new GetAllPlantViewModel {
                PlantID = plant.PlantID,
                PlantName = plant.PlantName,
                SowingDate = plant.SowingDate.ToString("dd/MM/yyyy HH:mm"),
                TypeName = planttype.TypeName
            };
            return result.ToList();
        }
    }
}

