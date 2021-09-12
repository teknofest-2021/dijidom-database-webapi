using System.ComponentModel.DataAnnotations;

namespace dijidom_database_webapi.Models
{
    public class PlantType
    {
        [Key]
        public int TypeID { get; set; }
        public string TypeName { get; set; }
    }
}