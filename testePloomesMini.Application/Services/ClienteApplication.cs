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
    public class ClienteApplication : ApplicationBase, IClienteApplication
    {
        private readonly IGetClientesDomain _getClientesDomain;
        private readonly IInsertClienteDomain _insertClienteDomain;
        public ClienteApplication(IGetClientesDomain getClientesDomain, IInsertClienteDomain insertClienteDomain)
        {
            _getClientesDomain = getClientesDomain;
            _insertClienteDomain = insertClienteDomain;
        }

        public List<vmCliente> GetClientes()
        {
            return List<vmCliente>(_getClientesDomain.GetClientes());
        }

        public bool InsertCliente(vmClienteFilter clienteFilter)
        {
            return _insertClienteDomain.InsertCliente(Read<Cliente>(clienteFilter));
        }
    }
}
