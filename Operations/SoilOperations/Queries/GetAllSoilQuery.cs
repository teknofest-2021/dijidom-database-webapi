using System.Linq;
using System.Collections.Generic;
using dijidom_database_webapi.Data;
using dijidom_database_webapi.Models;

namespace dijidom_database_webapi.Operations.SoilOperations.Queries
{
    public class GetAllSoilQuery
    {
        private readonly IDijiDomDBContext _dbContext;

        public GetAllSoilQuery(IDijiDomDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<GetAllSoilViewModel> Handle()
        {
            var result = from soil in _dbContext.Soils
                         join measurement in _dbContext.Measurements
                         on soil.SoilID equals measurement.SoilID
                         select new GetAllSoilViewModel
                         {
                             SoilID = soil.SoilID,
                             SoilTemperature = soil.SoilTemperature,
                             SoilHumidity = soil.SoilHumidity,
                             MeasurementDate = measurement.MeasurementDate
                         };
            return result.ToList();
        }
    }
}