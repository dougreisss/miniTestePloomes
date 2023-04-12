using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using testePloomesMini.Application.ViewModel;

namespace testePloomesMini.Application.Interfaces
{
    public interface IUsuarioApplication
    {
        public List<vmUsuario> GetUsuarios();
        public bool InsertUsuario(vmUsuario usuario);
    }
}
