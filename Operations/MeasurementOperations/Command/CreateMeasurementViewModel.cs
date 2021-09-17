using System;

namespace dijidom_database_webapi.Operations.MeasurementOperations.Command
{
    public class CreateMeasurementViewModel
    {
        public int PlantID { get; set; }
        public Single PlantHeight { get; set; }
        public Single SoilHumidity { get; set; }
        public Single SoilTemperature { get; set; }
        public Single AirQuality { get; set; }
        public Single AirTemperature { get; set; }
        public Single AirHumidity { get; set; }
        public DateTime MeasurementDate { get; set; }
    }
}