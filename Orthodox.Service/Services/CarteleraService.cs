using Orthodox.Data.Models;
using Orthodox.Service.Dto;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orthodox.Service.Services
{
    public class CarteleraService
    {
        // Inyección de Dependecias
        private readonly OrthodoxDbContext _orthodoxDbContext;

        public CarteleraService(OrthodoxDbContext dbContext)
        {
            _orthodoxDbContext = dbContext;
        }

        public List<CarteleraResponse> ObtenerTodos()
        {
            try
            {
                var carteleras = _orthodoxDbContext.Carteleras.ToList();

                List<CarteleraResponse> carteleraList = new List<CarteleraResponse>();

                foreach (var cartelera in carteleras)
                {
                    carteleraList.Add(new CarteleraResponse()
                    {
                        Id = cartelera.Id,
                        Titulo = cartelera.Titulo,
                        Fecha = cartelera.Fecha,
                        Contenido = cartelera.Contenido,
                        Tipo = cartelera.Tipo
                    });
                }

                return carteleraList;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public CarteleraResponse ObtenerPorId(int id)
        {
            try
            {
                var cartelera = _orthodoxDbContext.Carteleras
                    .FirstOrDefault(x => x.Id == id);

                var carteleraResponse = new CarteleraResponse()
                {
                    Id = cartelera.Id,
                    Titulo = cartelera.Titulo,
                    Fecha = cartelera.Fecha,
                    Contenido = cartelera.Contenido,
                    Tipo= cartelera.Tipo
                };

                return carteleraResponse;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Cartelera Agregar(CarteleraCreateRequest peticion)
        {
            try
            {
                var cartelera = new Cartelera()
                {
                    Titulo = peticion.Titulo,
                    Fecha = peticion.Fecha,
                    Contenido = peticion.Contenido,
                    Tipo= peticion.Tipo
                };

                _orthodoxDbContext.Carteleras.Add(cartelera);
                _orthodoxDbContext.SaveChanges();

                return cartelera;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Cartelera Actualizar(CarteleraUpdateRequest peticion)
        {
            try
            {
                var cartelera = _orthodoxDbContext.Carteleras
                    .FirstOrDefault(x => x.Id == peticion.Id);

                cartelera.Titulo = peticion.Titulo;
                cartelera.Fecha = peticion.Fecha;
                cartelera.Contenido = peticion.Contenido;
                cartelera.Tipo = peticion.Tipo;

                _orthodoxDbContext.SaveChanges();

                return cartelera;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Cartelera? Eliminar(int id)
        {
            try
            {
                var cartelera = _orthodoxDbContext.Carteleras
                    .FirstOrDefault(x => x.Id == id);

                _orthodoxDbContext.Remove(cartelera);
                _orthodoxDbContext.SaveChanges();

                return cartelera;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
