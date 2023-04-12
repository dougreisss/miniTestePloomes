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
    public class GetClientesDomain : IGetClientesDomain
    {
        private readonly IClienteRepository _clienteRepository;
        public GetClientesDomain(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        public List<Cliente> GetClientes()
        {
            return _clienteRepository.GetClientes();
        }
    }
}
