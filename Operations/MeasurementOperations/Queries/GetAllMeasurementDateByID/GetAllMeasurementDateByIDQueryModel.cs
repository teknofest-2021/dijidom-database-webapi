using System;

namespace dijidom_database_webapi.Operations.MeasurementOperations.Queries.GetAllMeasurementDateByID
{
    public class GetAllMeasurementDateByIDQueryModel
    {
        public int PlantID { get; set; }
        public DateTime MeasurementDate { get; set; }
    }
}