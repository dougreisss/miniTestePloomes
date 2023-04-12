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
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioApplication _usuarioApplication;
        public UsuarioController(IUsuarioApplication usuarioApplication)
        {
            _usuarioApplication = usuarioApplication;
        }

        [HttpGet("GetUsuarios")]
        public IActionResult GetUsuarios()
        {
            vmResult result = new vmResult();

            try
            {
                var lstUsuarios = _usuarioApplication.GetUsuarios();

                result.data = lstUsuarios;

                return Ok(result);
            }
            catch (Exception ex)
            {
                result.friendlyErrorMessage = "Houve um erro";
                result.stackTrace = ex.Message + "/n" + ex.StackTrace;
                return BadRequest(result); 
            }
        }

        [HttpPost("InsertUsuario")]
        public IActionResult InsertUsuario(vmUsuario usuario)
        {
            vmResult result = new vmResult();

            try
            {
                if (!_usuarioApplication.InsertUsuario(usuario))
                {
                    result.friendlyErrorMessage = "Não foi possível inserir este registro";
                    return BadRequest(result);
                }

                result.data = usuario;
                result.message = "Registro inserido com sucesso!";
                return Ok(result);
            }
            catch (Exception ex)
            {
                result.friendlyErrorMessage = "Houve um erro";
                result.stackTrace = ex.Message + "/n" + ex.StackTrace;
                return BadRequest(result); ;
            }
        }
    }
}
