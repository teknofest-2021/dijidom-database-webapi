using System;

namespace dijidom_database_webapi.Operations.PlantOperations.Queries
{
    public class PlantGetAllViewModel
    {
        public int PlantID { get; set; }
        public string PlantName { get; set; }
        public string TypeName { get; set; }
        public Single PlantHeight {get; set;}
    }
}