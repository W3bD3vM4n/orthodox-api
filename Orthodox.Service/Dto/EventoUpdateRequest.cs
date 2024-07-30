using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Orthodox.Service.Dto
{
    public class EventoUpdateRequest
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("fechaInicio")]
        public DateTime FechaInicio { get; set; }

        [JsonPropertyName("fechaFin")]
        public DateTime FechaFin { get; set; }

        [JsonPropertyName("descripcionDia")]
        public string DescripcionDia { get; set; }

        [JsonPropertyName("tonoCantico")]
        public string TonoCantico { get; set; }

        [JsonPropertyName("guiaAyuno")]
        public string GuiaAyuno { get; set; }

        [JsonPropertyName("codigoDeColoresAyuno")]
        public string? CodigoDeColoresAyuno { get; set; }

        [JsonPropertyName("fiestasLiturgicas")]
        public string? FiestasLiturgicas { get; set; }

        [JsonPropertyName("santosCelebrados")]
        public string SantosCelebrados { get; set; }

        [JsonPropertyName("guiaLiturgia")]
        public string GuiaLiturgia { get; set; }

        [JsonPropertyName("lecturaDiariaEpistola")]
        public string? LecturaDiariaEpistola { get; set; }

        [JsonPropertyName("lecturaDiariaEvangelio")]
        public string? LecturaDiariaEvangelio { get; set; }

        [JsonPropertyName("tituloIcono")]
        public string? TituloIcono { get; set; }

        [JsonPropertyName("descripcionIcono")]
        public string? DescripcionIcono { get; set; }
    }
}
