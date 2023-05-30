using LojaService.DTO;
using LojaService.Entities;
using LojaService.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LojaApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioService _usuarioService;

        public UsuarioController(IUsuarioService usuarioService)
        {
            _usuarioService = usuarioService;
        }

        // GET: api/<UsuarioController>
        [HttpGet]
        public ActionResult<IEnumerable<Usuario>> Get()
        {
            var retorno = _usuarioService.GetAll();
            return Ok(retorno);
        }

        // GET api/<UsuarioController>/5
        [HttpGet("{id}")]
        public ActionResult<Usuario> Get(int id)
        {
            var retorno = _usuarioService.GetById(id);
            if(retorno == null)
            {
                return NotFound();
            }
            return Ok(retorno);
        }

        // POST api/<UsuarioController>
        [HttpPost]
        public ActionResult Post([FromBody] Usuario usuario)
        {

            _usuarioService.Add(usuario);
            return Ok();
        }
        // POST api/<UsuarioController>
        [HttpPost("login")]
        public ActionResult<Usuario> Login([FromBody] LoginDTO login)
        {

            var usuarioLogado = _usuarioService.Login(login);
            if(usuarioLogado == null)
            {
                return NotFound();
            }
            return Ok(usuarioLogado);
        }


        // PUT api/<UsuarioController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Usuario usuario)
        {
            _usuarioService.Update(usuario);
            return Ok();
        }

        // DELETE api/<UsuarioController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            Usuario usuario = new Usuario() { IdUsuario = id };
            _usuarioService.Remove(usuario);
            return Ok();
        }
    }
}
