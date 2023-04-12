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
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioRepository _usuarioRepository;
        public UsuarioController(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }

        [HttpGet("GetUsuarios")]
        public IActionResult GetUsuarios()
        {
            try
            {

                var retorno = _usuarioRepository.GetUsuarios();

                return Ok(retorno);
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }


        [HttpPost("InsertUsuarios")]
        public IActionResult InsertUsuarios(Usuario usuario)
        {
            try
            {

                _usuarioRepository.InsertUsuarios(usuario);

                return Ok();
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }

    }
}
