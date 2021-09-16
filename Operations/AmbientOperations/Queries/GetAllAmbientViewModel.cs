using System;

namespace dijidom_database_webapi.Operations.AmbientOperations.Queries
{
    public class GetAllAmbientViewModel
    {
        public int AmbientID { get; set; }
        public Single AirQuality { get; set; }
        public Single AirTemperature { get; set; }
        public Single AirHumidity { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}