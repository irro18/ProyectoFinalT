using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitterClone.Services
{
    public class UsuarioService
    {
        private readonly UsuarioDataService _dataService;
        public UsuarioService(string connectionString)
        {
            _dataService = UsuarioDataService.GetInstance(connectionString);
        }

        public string AddUsuerr(Usuario usuario)
        {
            try
            {
                return _dataService.AddUsuerr(usuario) ? "Usuario agregado." : "Error al agregar.";

            }
            catch (Exception e)
            {
                return e.Message;
            }
        }

        public Usuario Jalar(string Nombre)
        {
            return _dataService.Jalar(Nombre);
        }
    }
}
