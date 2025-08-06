using System.Text.Json.Serialization;

namespace VisordeRickyMorty.Models
{
    public class ResponseCharacters
    {
        [JsonPropertyName("results")]
        public List<Character> Results { get; set; }
    }
}
