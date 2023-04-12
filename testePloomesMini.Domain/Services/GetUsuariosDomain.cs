using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using testePloomesMini.Domain.Interfaces.Command;
using testePloomesMini.Domain.Interfaces.Repository;
using testePloomesMini.WebApi.Models;

namespace testePloomesMini.Domain.Services
{
    public class GetUsuariosDomain : IGetUsuariosDomain
    {
        private readonly IUsuarioRepository _usuarioRepository;
        public GetUsuariosDomain(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }
        public List<Usuario> GetUsuarios()
        {
            return _usuarioRepository.GetUsuarios();
        }
    }
}
