using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using testePloomesMini.WebApi.Models;

namespace testePloomesMini.WebApi.Data.Interface
{
    public interface IClienteRepository
    {
        public List<Cliente> GetClientes();
        public void InsertCliente(Cliente cliente);

    }
}
