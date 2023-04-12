using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using testePloomesMini.Domain.Interfaces.Repository;
using testePloomesMini.Domain.Models.Enums;
using testePloomesMini.WebApi.Models;

namespace testePloomesMini.Infra.Data.Repository
{
    public class ClienteRepository : IClienteRepository
    {
        EnviromentDb.Enviroment db = EnviromentDb.Enviroment.PLM;

        public List<Cliente> GetClientes()
        {
            throw new NotImplementedException();
        }
    }
}
