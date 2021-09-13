using System.Linq;
using System.Collections.Generic;
using dijidom_database_webapi.Data;

namespace dijidom_database_webapi.Operations.MeasurementOperations.Queries.GetAllMeasurementByPlantID
{
    public class GetAllMeasurementByPlantIDQuery
    {
        private readonly IDijiDomDBContext _dbContext;

        public GetAllMeasurementByPlantIDQuery(IDijiDomDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public int PlantID { get; set; }
        public List<GetAllMeasurementByPlantIDViewModel> Handle()
        {
            var result = from mesurement in _dbContext.Measurements.Where(p => p.PlantID==PlantID)
                         join plant in _dbContext.Plants
                         on mesurement.PlantID equals plant.PlantID
                         join soil in _dbContext.Soils
                         on mesurement.SoilID equals soil.SoilID
                         join ambient in _dbContext.Ambients
                         on mesurement.AmbientID equals ambient.AmbientID
                         join planttype in _dbContext.PlantTypes
                         on plant.TypeID equals planttype.TypeID
                         orderby mesurement.MeasurementID descending
                         select new GetAllMeasurementByPlantIDViewModel
                         {
                             AirHumidity = ambient.AirHumidity,
                             AirQuality = ambient.AirQuality,
                             AirTemperature = ambient.AirTemperature,
                             PlantID = plant.PlantID,
                             PlantHeight = plant.PlantHeight,
                             PlantName = plant.PlantName,
                             SoilHumidity = soil.SoilHumidity,
                             SoilTemperature = soil.SoilTemperature,
                             TypeName = planttype.TypeName,
                             CreatedDate = mesurement.CreatedDate
                         };
            return result.ToList();
        }
    }
}