using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using testePloomesMini.Application.ViewModel;

namespace testePloomesMini.Application.Interfaces
{
    public interface IClienteApplication
    {
        public List<vmCliente> GetClientes();
        public bool InsertCliente(vmClienteFilter clienteFilter);
    }
}
