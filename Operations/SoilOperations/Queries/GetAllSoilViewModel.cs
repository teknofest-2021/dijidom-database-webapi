using System;

namespace dijidom_database_webapi.Operations.SoilOperations.Queries
{
    public class GetAllSoilViewModel
    {
        public int SoilID { get; set; }
        public int PlantID { get; set; }
        public string PlantName { get; set; }
        public Single SoilHumidity { get; set; }
        public Single SoilTemperature { get; set; }
        public String MeasurementDate { get; set; }
    }
}