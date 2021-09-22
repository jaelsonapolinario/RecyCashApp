using System.Collections.Generic;
using Newtonsoft.Json;

namespace RecyCashApp.Models
{
    public class ResultResponseModel
    {
        [JsonProperty("search")]
        public List<SearchItemModel> Searchs;
    }
}