using Microsoft.AspNetCore.Mvc.RazorPages;
using PokedexApp.Models;
using PokedexApp.Services;

namespace PokedexApp.Pages
{
    public class IndexModel : PageModel
    {
        private readonly PokeApiService _pokeApiService;

        public Pokemon Pokemon { get; set; }
        public IndexModel(PokeApiService pokeApiService)
        {
            _pokeApiService = pokeApiService;
        }

        public async Task OnGetAsync(string nome)
        {
            if (!string.IsNullOrEmpty(nome))
            {
                Pokemon = await _pokeApiService.GetPokemonAsync(nome);
            }
        }
    }
}
