using System.Text.Json.Serialization;

namespace PokedexApp.Models
{
    public class Pokemon
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string Nome { get; set; }

        [JsonPropertyName("height")]
        public double Altura { get; set; }

        [JsonPropertyName("weight")]
        public double Peso {  get; set; }

        [JsonPropertyName("front_default")]
        public string Sprite { get; set; }


    }
}
