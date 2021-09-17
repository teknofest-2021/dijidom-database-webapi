using System;

namespace dijidom_database_webapi.Operations.MeasurementOperations.Queries.GetAllMeasurementByPlantID
{
    public class GetAllMeasurementByPlantIDViewModel
    {
        public int PlantID { get; set; }
        public string PlantName { get; set; }
        public Single PlantHeight { get; set; }
        public string TypeName { get; set; }
        public Single AirQuality { get; set; }
        public Single AirTemperature { get; set; }
        public Single AirHumidity { get; set; }
        public Single SoilTemperature { get; set; }
        public Single SoilHumidity { get; set; }
        public DateTime MeasurementDate { get; set; }
        public DateTime SowingDate { get; set; }
    }
}