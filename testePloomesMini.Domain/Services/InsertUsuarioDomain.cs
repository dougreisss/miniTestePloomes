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
    public class InsertUsuarioDomain : IInsertUsuarioDomain
    {
        private readonly IUsuarioRepository _usuarioRepository;
        public InsertUsuarioDomain(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }
        public bool InsertUsuario(Usuario usuario)
        {
            return _usuarioRepository.InsertUsuario(usuario);
        }
    }
}
