using System;
using dijidom_database_webapi.Data;
using dijidom_database_webapi.Models;

namespace dijidom_database_webapi.Operations.MeasurementOperations.Command
{
    public class CreateMeasurementCommand
    {
        private readonly IDijiDomDBContext _dbContext;

        public CreateMeasurementViewModel Model { get; set; }

        public CreateMeasurementCommand(IDijiDomDBContext dbContext)
        {
            _dbContext = dbContext;
        }
        public ResultModel<CreateMeasurementViewModel> Handle()
        {
            try
            {
                Ambient ambient = new Ambient()
                {
                    AirQuality = Model.AirQuality,
                    AirHumidity = Model.AirHumidity,
                    AirTemperature = Model.AirTemperature,
                };

                Soil soil = new Soil()
                {
                    SoilHumidity = Model.SoilHumidity,
                    SoilTemperature = Model.SoilTemperature,
                };


                _dbContext.Ambients.Add(ambient);
                _dbContext.Soils.Add(soil);
                _dbContext.SaveChanges();

                Measurement measurement = new Measurement()
                {
                    PlantID = Model.PlantID,
                    AmbientID = ambient.AmbientID,
                    SoilID = soil.SoilID,
                    CreatedDate = Model.MeasurementDate
                };

                _dbContext.Measurements.Add(measurement);
                _dbContext.SaveChanges();
                return ResultModel<CreateMeasurementViewModel>.GenerateResult(Model, "Successfully written to database");
            }
            catch (Exception ex)
            {
                return ResultModel<CreateMeasurementViewModel>.GenerateResult(Model, "Could not write to database. " + ex.Message);
            }
        }
    }
}