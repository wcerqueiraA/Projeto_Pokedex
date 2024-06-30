using PokedexApp.Models;
using System.Text.Json;

namespace PokedexApp.Services
{
    public class PokeApiService
    {
        private readonly HttpClient _httpClient;

        public PokeApiService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<Pokemon> GetPokemonAsync(string nome)
        {
            var resposta = await _httpClient.GetStringAsync($"https://pokeapi.co/api/v2/pokemon/{nome.ToLower()}");
            return JsonSerializer.Deserialize<Pokemon>(resposta);
        }
    }
}
