using System.Text.Json.Serialization;

namespace PokedexApp.Models
{
    public class Tipo
    {

        [JsonPropertyName("slot")]
        public int slot { get; set; }
        public Tipo2 type { get; set; } = new Tipo2();

    }
}
