using Orthodox.Data.Models;
using Orthodox.Service.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orthodox.Service.Services
{
    public class PensamientoDiaService
    {
        // Inyección de Dependecias
        private readonly OrthodoxDbContext _orthodoxDbContext;

        public PensamientoDiaService(OrthodoxDbContext dbContext)
        {
            _orthodoxDbContext = dbContext;
        }

        public List<PensamientoDiaResponse> ObtenerTodos()
        {
            try
            {
                var pensamientosDia = _orthodoxDbContext.PensamientosDia.ToList();

                List<PensamientoDiaResponse> pensamientoDiaList = new List<PensamientoDiaResponse>();

                foreach (var pensamientoDia in pensamientosDia)
                {
                    pensamientoDiaList.Add(new PensamientoDiaResponse()
                    {
                        Id = pensamientoDia.Id,
                        Autor = pensamientoDia.Autor,
                        Frase = pensamientoDia.Frase
                    });
                }

                return pensamientoDiaList;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public PensamientoDiaResponse ObtenerPorId(int id)
        {
            try
            {
                var pensamientoDia = _orthodoxDbContext.PensamientosDia
                    .FirstOrDefault(x => x.Id == id);

                var pensamientoDiaResponse = new PensamientoDiaResponse()
                {
                    Id = pensamientoDia.Id,
                    Autor = pensamientoDia.Autor,
                    Frase = pensamientoDia.Frase
                };

                return pensamientoDiaResponse;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
