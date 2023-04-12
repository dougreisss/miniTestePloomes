using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace testePloomesMini.WebApi.Models
{
    public class Cliente
    {
        public int IdCliente { get; set; }
        public string EmailUsuario { get; set; }
        public string NomeCliente { get; set; }
        public DateTime DataCriacaoUsuario { get; set; }
    }
}
