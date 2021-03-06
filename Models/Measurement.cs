using System;

namespace dijidom_database_webapi.Models
{
    public class Measurement
    {
        public int MeasurementID { get; set; }
        public int PlantID { get; set; }
        public Single PlantHeight { get; set; }
        public int AmbientID { get; set; }
        public int SoilID { get; set; }
        public DateTime MeasurementDate { get; set; }
    }
}