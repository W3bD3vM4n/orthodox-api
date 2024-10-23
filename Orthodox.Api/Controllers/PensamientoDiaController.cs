using Microsoft.AspNetCore.Mvc;
using Orthodox.Service.Services;

namespace Orthodox.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PensamientoDiaController : Controller
    {
        // Inyección de Dependecias
        private readonly PensamientoDiaService _pensamientoDiaService;

        public PensamientoDiaController(PensamientoDiaService pensamientoDiaService)
        {
            _pensamientoDiaService = pensamientoDiaService;
        }

        [HttpGet]
        public ActionResult Obtener()
        {
            var pensamientoDia = _pensamientoDiaService.ObtenerTodos();

            if (!pensamientoDia.Any())
            {
                return NotFound();
            }

            return Ok(pensamientoDia);
        }

        [HttpGet("{id}")]
        public ActionResult PorId(int id)
        {
            var pensamientoDia = _pensamientoDiaService.ObtenerPorId(id);

            if (pensamientoDia == null)
            {
                return NotFound();
            }

            return Ok(pensamientoDia);
        }
    }
}
