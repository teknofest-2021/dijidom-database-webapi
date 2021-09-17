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
            var result = from mesurement in _dbContext.Measurements
            join plant in _dbContext.Plants
            on mesurement.PlantID equals plant.PlantID
            join soil in _dbContext.Soils
            on mesurement.SoilID equals soil.SoilID
            join ambient in _dbContext.Ambients
            on mesurement.AmbientID equals ambient.AmbientID
            join planttype in _dbContext.PlantTypes
            on plant.TypeID equals planttype.TypeID
            orderby mesurement.MeasurementID descending
            select new GetLastMeasurementViewModel {
                AirHumidity = ambient.AirHumidity,
                AirQuality = ambient.AirQuality,
                AirTemperature = ambient.AirTemperature,
                PlantID = plant.PlantID,
                PlantHeight = mesurement.PlantHeight,
                PlantName = plant.PlantName,
                SowingDate = plant.SowingDate,
                SoilHumidity = soil.SoilHumidity,
                SoilTemperature = soil.SoilTemperature,
                TypeName = planttype.TypeName,
                MeasurementDate = mesurement.MeasurementDate,
            };
            //Basic Distinc
            var data = result.ToList().GroupBy(g => g.PlantID).Select(s => s.First()).ToList();
            return data;
        }
    }
}