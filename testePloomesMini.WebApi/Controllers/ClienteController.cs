using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using testePloomesMini.WebApi.Data.Interface;
using testePloomesMini.WebApi.Models;

namespace testePloomesMini.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private IClienteRepository _clienteRepository;
        public ClienteController(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        [HttpGet("GetClientes")]
        public IActionResult GetClientes()
        {
            try
            {
                var retorno = _clienteRepository.GetClientes();

                return Ok(retorno);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("InsertCliente")]
        public IActionResult InsertCliente(Cliente cliente)
        {
            try
            {

                _clienteRepository.InsertCliente(cliente);

                return Ok();
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }
    }
}
