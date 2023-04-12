using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using testePloomesMini.Application.Interfaces;
using testePloomesMini.Application.ViewModel;

namespace testePloomesMini.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private readonly IClienteApplication _clienteApplication;
        public ClienteController(IClienteApplication clienteApplication)
        {
            _clienteApplication = clienteApplication;
        }

        [HttpGet("GetClientes")]
        public IActionResult GetClientes()
        {
            vmResult result = new vmResult();

            try
            {
                var lstClientes = _clienteApplication.GetClientes();

                result.data = lstClientes;

                return Ok(result);
            }
            catch (Exception ex)
            {
                result.friendlyErrorMessage = "Houve um erro";
                result.stackTrace = ex.Message + "/n" + ex.StackTrace;
                return BadRequest(result);
            }
        }

        [HttpPost("InsertCliente")]
        public IActionResult InsertCliente(vmClienteFilter clienteFilter)
        {
            vmResult result = new vmResult();

            try
            {
                if (!_clienteApplication.InsertCliente(clienteFilter))
                {
                    result.friendlyErrorMessage = "Não foi possível inserir este registro";
                    return BadRequest(result);
                }

                result.data = clienteFilter;
                result.message = "Registro inserido com sucesso!";
                return Ok(result);
            }
            catch (Exception ex)
            {
                result.friendlyErrorMessage = "Houve um erro";
                result.stackTrace = ex.Message + "/n" + ex.StackTrace;
                return BadRequest(result);
            }
        }
    }
}
