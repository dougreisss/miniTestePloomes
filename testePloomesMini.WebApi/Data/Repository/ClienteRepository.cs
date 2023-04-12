using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using testePloomesMini.WebApi.Data.Interface;
using testePloomesMini.WebApi.Models;

namespace testePloomesMini.WebApi.Data.Repository
{
    public class ClienteRepository : IClienteRepository
    {
        public List<Cliente> GetClientes()
        {
            List<Cliente> lstCliente = new List<Cliente>();

            using (var conn = new SqlConnection("Server=localhost\\SQLEXPRESS;Database=prjMiniPloomes;Trusted_Connection=True"))
            {
                using (SqlCommand cmd = new SqlCommand("select * from PLM.Cliente", conn))
                {
                    conn.Open();

                    var retorno = cmd.ExecuteReader();

                    while (retorno.Read())
                    {
                        Cliente cliente = new Cliente();

                        cliente.IdCliente = int.Parse(retorno[0].ToString());
                        cliente.EmailUsuario = retorno[1].ToString();
                        cliente.NomeCliente = retorno[2].ToString();
                        cliente.DataCriacaoUsuario = DateTime.Parse(retorno[3].ToString());

                        lstCliente.Add(cliente);
                    }

                    conn.Close();
                }
            }

            return lstCliente;
        }

        public void InsertCliente(Cliente cliente)
        {
            using (var conn = new SqlConnection("Server=localhost\\SQLEXPRESS;Database=prjMiniPloomes;Trusted_Connection=True"))
            {
                using (SqlCommand cmd = new SqlCommand($"insert into PLM.Cliente (EmailUsuario, NomeCliente, DataCriacaoUsuario) values ('{cliente.EmailUsuario}', '{cliente.NomeCliente}', GETDATE())", conn))
                {
                    conn.Open();

                    cmd.ExecuteNonQuery();

                    conn.Close();
                }
            }
        }
    }
}
