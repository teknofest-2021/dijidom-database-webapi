using System.Linq;
using System.Collections.Generic;
using dijidom_database_webapi.Data;

namespace dijidom_database_webapi.Operations.MeasurementOperations.Queries.GetLastMeasurement
{
    public class GetLastMeasurementQuery
    {
        private readonly IDijiDomDBContext _dbContext;

        public GetLastMeasurementQuery(IDijiDomDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<GetLastMeasurementViewModel> Handle()
        {
            var result = from measurement in _dbContext.Measurements
            join plant in _dbContext.Plants
            on measurement.PlantID equals plant.PlantID
            join soil in _dbContext.Soils
            on measurement.SoilID equals soil.SoilID
            join ambient in _dbContext.Ambients
            on measurement.AmbientID equals ambient.AmbientID
            join planttype in _dbContext.PlantTypes
            on plant.TypeID equals planttype.TypeID
            orderby measurement.MeasurementID descending
            select new GetLastMeasurementViewModel {
                AirHumidity = ambient.AirHumidity,
                AirQuality = ambient.AirQuality,
                AirTemperature = ambient.AirTemperature,
                PlantID = plant.PlantID,
                PlantHeight = measurement.PlantHeight,
                PlantName = plant.PlantName,
                SowingDate = plant.SowingDate,
                SoilHumidity = soil.SoilHumidity,
                SoilTemperature = soil.SoilTemperature,
                TypeName = planttype.TypeName,
                MeasurementDate = measurement.MeasurementDate,
            };
            //Basic Distinc
            var data = result.ToList().GroupBy(g => g.PlantID).Select(s => s.First()).ToList();
            return data;
        }
    }
}