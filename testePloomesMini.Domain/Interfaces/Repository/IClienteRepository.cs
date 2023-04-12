using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using testePloomesMini.WebApi.Models;

namespace testePloomesMini.Domain.Interfaces.Repository
{
    public interface IClienteRepository
    {
        public List<Cliente> GetClientes();
    }
}
