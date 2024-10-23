using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orthodox.Data.Models
{
    public partial class PensamientoDia
    {
        public int Id { get; set; }
        public string? Autor { get; set; }
        public string? Frase { get; set; }
    }
}
