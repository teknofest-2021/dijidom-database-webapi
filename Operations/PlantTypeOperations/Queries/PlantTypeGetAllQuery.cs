using System.Collections.Generic;
using System.Linq;
using dijidom_database_webapi.Data;
using dijidom_database_webapi.Models;

namespace dijidom_database_webapi.Operations.PlantTypeOperations.Queries
{
    public class PlantTypeGetAllQuery
    {
        private readonly IDijiDomDBContext _dbContext;

        public PlantTypeGetAllQuery(IDijiDomDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<PlantType> Handle()
        {
            List<PlantType> plantTypes;
            plantTypes = _dbContext.PlantTypes.ToList();
            if(plantTypes == null)
                plantTypes = new List<PlantType>();
            return plantTypes;
        }
    }
}