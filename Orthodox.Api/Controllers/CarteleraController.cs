using Microsoft.AspNetCore.Mvc;
using Orthodox.Data.Models;
using Orthodox.Service.Dto;
using Orthodox.Service.Services;

namespace Orthodox.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarteleraController : Controller
    {
        // Inyección de Dependecias
        private readonly CarteleraService _carteleraService;

        public CarteleraController(CarteleraService carteleraService)
        {
            _carteleraService = carteleraService;
        }

        [HttpGet]
        public ActionResult Obtener()
        {
            var cartelera = _carteleraService.ObtenerTodos();

            if (!cartelera.Any())
            {
                return NotFound();
            }

            return Ok(cartelera);
        }

        [HttpGet("{id}")]
        public ActionResult PorId(int id)
        {
            var cartelera = _carteleraService.ObtenerPorId(id);

            if (cartelera == null)
            {
                return NotFound();
            }

            return Ok(cartelera);
        }

        [HttpPost]
        public ActionResult Crear(CarteleraCreateRequest peticion)
        {
            return Ok(_carteleraService.Agregar(peticion));
        }

        [HttpPut]
        public ActionResult Refrescar(CarteleraUpdateRequest peticion)
        {
            return Ok(_carteleraService.Actualizar(peticion));
        }

        [HttpDelete("{id}")]
        public ActionResult Borrar(int id)
        {
            bool ocurrioUnError = false;

            _carteleraService.Eliminar(id);

            if (ocurrioUnError)
            {
                return BadRequest();
            }

            return NoContent();
        }
    }
}
