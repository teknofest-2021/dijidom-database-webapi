using System;

namespace dijidom_database_webapi.Operations.PlantOperations.Queries
{
    public class GetAllPlantViewModel
    {
        public int PlantID { get; set; }
        public string PlantName { get; set; }
        public string TypeName { get; set; }
        public DateTime SowingDate { get; set; }
    }
}