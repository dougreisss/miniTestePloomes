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
    public class InsertClienteDomain : IInsertClienteDomain
    {
        private readonly IClienteRepository _clienteRepository;
        public InsertClienteDomain(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }
        public bool InsertCliente(Cliente cliente)
        {
            return _clienteRepository.InsertCliente(cliente);
        }
    }
}
