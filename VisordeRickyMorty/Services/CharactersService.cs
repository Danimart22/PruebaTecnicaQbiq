using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using VisordeRickyMorty.Models;
namespace VisordeRickyMorty.Services

{

    public class CharactersService
    {
        private readonly HttpClient _httpClient;

        public CharactersService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<List<Character>> GetCharactersAsync()
        {
            var response = await _httpClient.GetFromJsonAsync<ResponseCharacters>("https://rickandmortyapi.com/api/character");
            return response.Results;
        }
    }
}
