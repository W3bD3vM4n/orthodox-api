using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Orthodox.Service.Dto
{
    public class UsuarioRequest
    {
        [JsonPropertyName("nombre")]
        public string Nombre { get; set; }

        [JsonPropertyName("contrasena")]
        public string Contrasena { get; set; }
    }
}
