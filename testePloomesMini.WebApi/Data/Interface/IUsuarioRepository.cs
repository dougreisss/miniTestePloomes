using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using testePloomesMini.WebApi.Models;

namespace testePloomesMini.WebApi.Data.Interface
{
    public interface IUsuarioRepository
    {
        public List<Usuario> GetUsuarios();
        public void InsertUsuarios(Usuario usuario);
    }
}
