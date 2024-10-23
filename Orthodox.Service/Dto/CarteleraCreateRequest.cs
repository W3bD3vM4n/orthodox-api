using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Orthodox.Service.Dto
{
    public class CarteleraCreateRequest
    {
        [JsonPropertyName("titulo")]
        public string? Titulo { get; set; }

        [JsonPropertyName("fecha")]
        public DateTime Fecha { get; set; }

        [JsonPropertyName("contenido")]
        public string? Contenido { get; set; }

        [JsonPropertyName("tipo")]
        public string? Tipo { get; set; }
    }
}
