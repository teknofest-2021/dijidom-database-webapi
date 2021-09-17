using System;

namespace dijidom_database_webapi.Operations.PlantOperations.Command
{
    public class CreatePlantViewModel
    {
        public string PlantName { get; set; }
        public int TypeID { get; set; }
        public DateTime SowingDate { get; set; }
    }
}