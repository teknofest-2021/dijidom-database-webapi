using System;

namespace dijidom_database_webapi.Operations.MeasurementOperations.Queries.MesurementGetAllByPlantID
{
    public class MesurementGetAllByPlantIDViewModel
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
        public DateTime CreatedDate { get; set; }
    }
}