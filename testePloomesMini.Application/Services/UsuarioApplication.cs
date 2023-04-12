using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using testePloomesMini.Application.Interfaces;
using testePloomesMini.Application.ViewModel;
using testePloomesMini.Domain.Interfaces.Command;
using testePloomesMini.WebApi.Models;

namespace testePloomesMini.Application.Services
{
    public class UsuarioApplication : ApplicationBase, IUsuarioApplication
    {
        private readonly IGetUsuariosDomain _getUsuariosDomain;
        private readonly IInsertUsuarioDomain _insertUsuarioDomain;

        public UsuarioApplication(IGetUsuariosDomain getUsuariosDomain, IInsertUsuarioDomain insertUsuarioDomain)
        {
            _getUsuariosDomain = getUsuariosDomain;
            _insertUsuarioDomain = insertUsuarioDomain;
        }

        public List<vmUsuario> GetUsuarios()
        {
            return List<vmUsuario>(_getUsuariosDomain.GetUsuarios());
        }

        public bool InsertUsuario(vmUsuario usuario)
        {
            return _insertUsuarioDomain.InsertUsuario(Read<Usuario>(usuario));
        }
    }
}
