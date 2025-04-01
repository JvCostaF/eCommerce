using eCommerce.Models;
using eCommerce.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace eCommerce.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        /*
        Estamos recebendo dentro do controller, via injeção de dependência, o repository de
        usuário, para ser utilizado pelas rotas.
        */
        private readonly IUsuarioRepository _repository;

        public UsuarioController(IUsuarioRepository repository)
        {
            this._repository = repository;
        }

        [HttpGet]
        public IActionResult GetUsers()
        {
            var listaDeUsuarios = _repository.Get();
            return Ok(listaDeUsuarios);
        }

        [HttpGet("{Id}")]
        public IActionResult Get(int Id)
        {
            var usuario = _repository.Get(Id);
            if(usuario == null)
                return NotFound("Usuário não encontrado");
            return Ok(usuario);
        }

        [HttpPost]
        public IActionResult Add([FromBody]Usuario usuario)
        {
            _repository.Add(usuario);
            return Ok(usuario);
        }

        [HttpPut("{Id}")]
        public IActionResult Update([FromBody]Usuario usuario, int Id)
        {
            _repository.Update(usuario);
            return Ok(usuario);
        }

        [HttpDelete("{Id}")]
        public IActionResult Delete(int id)
        {
            _repository.Delete(id);
            return Ok();
        }
    }
}
