using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using testePloomesMini.Domain.Interfaces.Repository;
using testePloomesMini.Domain.Models.Enums;
using testePloomesMini.Infra.Data.DbConfig;
using testePloomesMini.WebApi.Models;

namespace testePloomesMini.Infra.Data.Repository
{
    public class ClienteRepository : IClienteRepository
    {
        EnviromentDb.Enviroment db = EnviromentDb.Enviroment.PLM;

        public List<Cliente> GetClientes()
        {
            DbConfigRepository dbConfig = new DbConfigRepository();
            return dbConfig.ExecuteList<Cliente>(db, "PLM.spGetClientes", null);
        }

        public bool InsertCliente(Cliente cliente)
        {
            DbConfigRepository dbConfig = new DbConfigRepository();
            int ret = dbConfig.ExecuteNonQuery(db, "PLM.spInsertCliente", new {
            
                cliente.EmailUsuario,
                cliente.NomeCliente

            });

            return ret > 0 ? true : false;
        }
    }
}
