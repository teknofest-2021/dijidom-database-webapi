using System.Linq;
using System.Collections.Generic;
using dijidom_database_webapi.Data;
using dijidom_database_webapi.Models;

namespace dijidom_database_webapi.Operations.SoilOperations.Queries
{
    public class SoilGetAllQuery
    {
        private readonly IDijiDomDBContext _dbContext;

        public SoilGetAllQuery(IDijiDomDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<Soil> Handle()
        {
            List<Soil> soils;
            soils = _dbContext.Soils.ToList();
            if(soils == null)
                soils = new List<Soil>();
            return soils;
        }
    }
}