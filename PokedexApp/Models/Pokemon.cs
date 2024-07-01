using System.Text.Json.Serialization;
using static System.Net.WebRequestMethods;

namespace PokedexApp.Models
{
    public class Pokemon
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string Nome { get; set; }

        [JsonPropertyName("types")]
        public List<Tipo> Tipos { get; set; }

        [JsonPropertyName("height")]
        public double Altura { get; set; }

        [JsonPropertyName("weight")]
        public double Peso { get; set; }
        [JsonPropertyName("sprites")]
        public Sprite Sprites { get; set; }

    }

   

}
