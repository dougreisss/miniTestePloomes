using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using testePloomesMini.WebApi.Data.Interface;
using testePloomesMini.WebApi.Models;

namespace testePloomesMini.WebApi.Data.Repository
{
    public class UsuarioRepository : IUsuarioRepository
    {
        public List<Usuario> GetUsuarios()
        {
            List<Usuario> lstUsuario = new List<Usuario>();

            using (var conn = new SqlConnection("Server=localhost\\SQLEXPRESS;Database=prjMiniPloomes;Trusted_Connection=True")) 
            {
                using (SqlCommand cmd = new SqlCommand("select * from PLM.Usuario", conn))
                {
                    conn.Open();

                    var retorno = cmd.ExecuteReader();

                    while (retorno.Read())
                    {
                        Usuario usuario = new Usuario();

                        usuario.EmailUsuario = retorno[0].ToString();
                        usuario.NomeUsuario = retorno[1].ToString();

                        lstUsuario.Add(usuario);
                    }

                    conn.Close();
                }
            }

            return lstUsuario;
        }

        public void InsertUsuarios(Usuario usuario)
        {
            using (var conn = new SqlConnection("Server=localhost\\SQLEXPRESS;Database=prjMiniPloomes;Trusted_Connection=True"))
            {
                using (SqlCommand cmd = new SqlCommand($"insert into PLM.Usuario values ('{usuario.EmailUsuario}', '{usuario.NomeUsuario}')", conn))
                {
                    conn.Open();

                    cmd.ExecuteNonQuery();

                    conn.Close();
                }
            }
        }
    }
}
