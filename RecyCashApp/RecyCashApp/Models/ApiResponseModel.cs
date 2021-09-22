using System.Collections.Generic;
using Newtonsoft.Json;

namespace RecyCashApp.Models
{
    public class ApiResponseModel
    {
        [JsonProperty("results")]
        public List<ResultResponseModel> Results;
    }
}