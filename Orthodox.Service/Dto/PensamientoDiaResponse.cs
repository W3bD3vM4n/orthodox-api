using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Orthodox.Service.Dto
{
    public class PensamientoDiaResponse
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("autor")]
        public string? Autor { get; set; }

        [JsonPropertyName("frase")]
        public string? Frase { get; set; }
    }
}
