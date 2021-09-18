using System.Linq;
using System.Collections.Generic;
using dijidom_database_webapi.Data;
using System;

namespace dijidom_database_webapi.Operations.MeasurementOperations.Queries.GetAllMeasurementDateByID
{
    public class GetAllMeasurementDateByIDQuery
    {
        private readonly IDijiDomDBContext _dbContext;

        public GetAllMeasurementDateByIDQuery(IDijiDomDBContext dbContext)
        {
            _dbContext = dbContext;
        }
        public GetAllMeasurementDateByIDQueryModel Model { get; set; }
        public List<GetAllMeasurementDateByIDViewModel> Handle()
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
                         where measurement.PlantID == Model.PlantID
                         where measurement.MeasurementDate.Year == Model.MeasurementDate.Year
                         where measurement.MeasurementDate.Month == Model.MeasurementDate.Month
                         where measurement.MeasurementDate.Day == Model.MeasurementDate.Day
                         select new GetAllMeasurementDateByIDViewModel
                         {
                             AirHumidity = ambient.AirHumidity,
                             AirQuality = ambient.AirQuality,
                             AirTemperature = ambient.AirTemperature,
                             PlantID = plant.PlantID,
                             PlantHeight = measurement.PlantHeight,
                             PlantName = plant.PlantName,
                             SowingDate = plant.SowingDate.ToString("dd/MM/yyyy HH:mm"),
                             SoilHumidity = soil.SoilHumidity,
                             SoilTemperature = soil.SoilTemperature,
                             TypeName = planttype.TypeName,
                             MeasurementDate = measurement.MeasurementDate.ToString("dd/MM/yyyy HH:mm"),
                         };
            return result.ToList();
        }
    }
}