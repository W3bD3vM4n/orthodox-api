using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orthodox.Data.Models
{
    public partial class Cartelera
    {
        public int Id { get; set; }
        public string? Titulo { get; set; }
        public DateTime Fecha { get; set; }
        public string? Contenido { get; set; }
        public string? Tipo { get; set; }
    }
}
