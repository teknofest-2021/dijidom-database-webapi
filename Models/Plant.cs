using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace dijidom_database_webapi.Models
{
    public class Plant
    {
        [Key]
        public int PlantID { get; set; }
        public string PlantName { get; set; }
        public int TypeID { get; set; }
        public DateTime SowingDate { get; set; }
    }
}