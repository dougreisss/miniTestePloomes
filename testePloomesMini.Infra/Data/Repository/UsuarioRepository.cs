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
    public class UsuarioRepository : IUsuarioRepository
    {
        EnviromentDb.Enviroment db = EnviromentDb.Enviroment.PLM;

        public List<Usuario> GetUsuarios()
        {
            DbConfigRepository dbConfig = new DbConfigRepository();
            return dbConfig.ExecuteList<Usuario>(db, "PLM.spGetUsuarios", null);
        }

        public bool InsertUsuario(Usuario usuario)
        {
            DbConfigRepository dbConfig = new DbConfigRepository();

            int ret = dbConfig.ExecuteNonQuery(db, "PLM.spInsertUsuario", new {

                usuario.EmailUsuario,
                usuario.NomeUsuario

            });

            return ret > 0 ? true : false;
        }
    }
}
