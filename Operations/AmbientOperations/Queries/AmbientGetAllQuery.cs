using System.Collections.Generic;
using System.Linq;
using dijidom_database_webapi.Data;
using dijidom_database_webapi.Models;

namespace dijidom_database_webapi.Operations.AmbientOperations.Queries
{
    public class AmbientGetAllQuery
    {
        private readonly IDijiDomDBContext _dbContext;

        public AmbientGetAllQuery(IDijiDomDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<Ambient> Handle()
        {
            List<Ambient> ambients;
            ambients = _dbContext.Ambients.ToList();
            if(ambients == null)
                ambients = new List<Ambient>();
            return ambients;
        }
    }
}