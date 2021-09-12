namespace dijidom_database_webapi.Models
{
    public class ResultModel<TData>
    {
        public TData Data { get; set; }
        public string Message {get; set;}

        public static ResultModel<TData> GenerateResult(TData data, string message)
        {
            ResultModel<TData> result = new ResultModel<TData>(){
                Data = data,
                Message = message
            };

            return result;
        }
    }
}