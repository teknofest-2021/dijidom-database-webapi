using System;
using System.ComponentModel.DataAnnotations;

namespace dijidom_database_webapi.Models
{
    public class Ambient
    {
        [Key]
        public int AmbientID { get; set; }
        public Single AirQuality { get; set; }
        public Single AirTemperature { get; set; }
        public Single AirHumidity { get; set; }
    }
}