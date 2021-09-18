using System.Collections.Generic;
using System.Linq;
using dijidom_database_webapi.Data;

namespace dijidom_database_webapi.Operations.AmbientOperations.Queries
{
    public class GetAllAmbientQuery
    {
        private readonly IDijiDomDBContext _dbContext;

        public GetAllAmbientQuery(IDijiDomDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<GetAllAmbientViewModel> Handle()
        {
            var result = from ambient in _dbContext.Ambients
                         join measurement in _dbContext.Measurements
                         on ambient.AmbientID equals measurement.AmbientID
                         select new GetAllAmbientViewModel
                         {
                             AmbientID = ambient.AmbientID,
                             AirTemperature = ambient.AirTemperature,
                             AirHumidity = ambient.AirHumidity,
                             AirQuality = ambient.AirQuality,
                             MeasurementDate = measurement.MeasurementDate.ToString("dd/MM/yyyy HH:mm")
                         };
            return result.ToList();
        }
    }
}
