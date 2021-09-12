using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace dijidom_database_webapi.Models
{
    public class Soil
    {
        [Key]
        public int SoilID { get; set; }
        public Single SoilHumidity { get; set; }
        public Single SoilTemperature { get; set; }
    }
}