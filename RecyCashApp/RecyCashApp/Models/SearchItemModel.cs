using Newtonsoft.Json;

namespace RecyCashApp.Models
{
    public class SearchItemModel
    {
        [JsonProperty("nome")]
        public string Nome { get; set; }
        [JsonProperty("avaliacao")]
        public double Avaliacao { get; set; }
        [JsonProperty("distancia")]
        public double Distancia { get; set; }
        [JsonProperty("iniciais")]
        public string Iniciais { get; set; }
    }
}