using Orthodox.Data.Models;
using Orthodox.Service.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orthodox.Service.Services
{
    public class UsuarioService
    {
        // Inyección de Dependecias
        private readonly CalendarioDbContext _calendarioDbContext;

        public UsuarioService(CalendarioDbContext dbContext)
        {
            _calendarioDbContext = dbContext;
        }

        public bool ValidarUsuario(UsuarioRequest usuarioRequest)
        {
            try
            {
                var usuario = _calendarioDbContext.Usuarios
                                                    .FirstOrDefault(x=> x.Nombre == usuarioRequest.Nombre 
                                                                    && x.Contrasena == usuarioRequest.Contrasena);

                return usuario != null ? true : false;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
