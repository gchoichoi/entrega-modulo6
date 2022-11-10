using Microsoft.AspNetCore.Mvc;
using OncovoApi.Model;
using OncovoApi.Repository;

namespace OncovoApi.Controllers
{
    [ApiController] //esse comando mostra que é uma Api Controller = @RestCotroller
    [Route("api/[controller]")] //esse anuncia a rota = @RestMapping("/api")

    public class DestinoController : ControllerBase
    {
        //Injetar dependencia do repositório
        private readonly IDestinoRepository _repository;

        public DestinoController(IDestinoRepository repository){
            _repository = repository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll(){
            var destinos = await _repository.GetDestinos();
            return destinos.Any() ? Ok(destinos) : NoContent();
        }

        [HttpGet("{Id}")]
        public async Task<IActionResult> GetById(int Id){
            var destino = await _repository.GetDestinosById(Id);
            return destino != null ? Ok(destino) : NotFound("Destino não encontrado.");
        }

        [HttpPost]
        public async Task<IActionResult> Post(Destino destino){
            _repository.AddDestino(destino);
            return await _repository.SaveChangesAsync() ? Ok("Destino Adicionado") : BadRequest("Algo deu errado");
        }

        [HttpPut("{Id}")]
        public async Task<IActionResult> Atualizar(int Id, Destino destino){
            var destinoExiste = await _repository.GetDestinosById(Id);
            if(destinoExiste == null) return NotFound("Destino não encontrado.");

            destinoExiste.CidadeNome = destino.CidadeNome ?? destinoExiste.CidadeNome;
            destinoExiste.EstadoPaisNome = destino.EstadoPaisNome ?? destino.EstadoPaisNome;

            _repository.AtualizarDestino(destinoExiste);

            return await _repository.SaveChangesAsync() ? Ok("Destino atualizado.") : BadRequest("Algo deu errado.");
        }


        [HttpDelete ("{Id}")]
        public async Task<IActionResult> Delete(int Id){
            var destinoExiste = await _repository.GetDestinosById(Id);
            if(destinoExiste == null) return NotFound("Destino não encontrado.");

            _repository.DeletarDestino(destinoExiste);

            return await _repository.SaveChangesAsync() ? Ok("Usuário atualizado") : BadRequest("Algo deu errado.");
        }
    }
}