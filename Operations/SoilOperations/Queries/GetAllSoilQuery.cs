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
                         join plant in _dbContext.Plants
                         on measurement.PlantID equals plant.PlantID
                         orderby soil.SoilID descending
                         select new GetAllSoilViewModel
                         {
                             PlantID = measurement.PlantID,
                             PlantName = plant.PlantName,
                             SoilID = soil.SoilID,
                             SoilTemperature = soil.SoilTemperature,
                             SoilHumidity = soil.SoilHumidity,
                             MeasurementDate = measurement.MeasurementDate.AddHours(-3).ToString("dd/MM/yyyy HH:mm")
                         };
            return result.ToList();
        }
    }
}