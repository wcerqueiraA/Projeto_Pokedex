using System.Text.Json.Serialization;

namespace PokedexApp.Models
{
    public class Sprite
    {
        [JsonPropertyName("back_default")]
        public string Back_default { get; set; }

        [JsonPropertyName("back_shiny")]
        public string Back_shiny { get; set; }

        [JsonPropertyName("front_default")]
        public string Front_default { get; set; }

        [JsonPropertyName("front_shiny")]
        public string Front_shiny { get; set; }
    }
}
