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
        private readonly OrthodoxDbContext _orthodoxDbContext;

        public UsuarioService(OrthodoxDbContext dbContext)
        {
            _orthodoxDbContext = dbContext;
        }

        public bool ValidarUsuario(UsuarioRequest usuarioRequest)
        {
            try
            {
                var usuario = _orthodoxDbContext.Usuarios
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
