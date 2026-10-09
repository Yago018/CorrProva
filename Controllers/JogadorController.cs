using CorrProva.Models;
using CorrProva.Repository;
using Microsoft.AspNetCore.Mvc;

namespace CorrProva.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class JogadorController : ControllerBase
    {
        private readonly IJogadorRepository _jogadorRepository;

        public JogadorController(IJogadorRepository jogadorRepository)
        {
            _jogadorRepository = jogadorRepository;
        }

        [HttpPost]
        public IActionResult Cadastrar([FromBody] Jogador jogador)
        {
            if (_jogadorRepository.ObterPorCPF(jogador.CPF) is not null)
                return Conflict("Jogador já foi cadastrado.");

            _jogadorRepository.Cadastrar(jogador);
            return Ok("Jogador cadastrado com sucesso.");
        }

        [HttpGet("ListarJogadores")]
        public IActionResult ListarJogadores()
        {
            return Ok(_jogadorRepository.ObterTodos());
        }

        [HttpPost("RegistrarResultado")]
        public IActionResult RegistrarResultado(
            [FromBody] ResultadoPeneira resultado)
        {
            var jogador = _jogadorRepository.ObterPorCPF(resultado.CPF);

            if (jogador is null)
                return NotFound(
                    "Jogador não encontrado. Resultado não registrado.");

            if (jogador.Peneira.HasValue)
                return Conflict(
                    "O resultado da peneira já foi registrado para este jogador.");

            bool aprovado = resultado.Aprovado!.Value;
            _jogadorRepository.RegistrarResultado(resultado.CPF, aprovado);

            return Ok("Resultado da peneira registrado com sucesso.");
        }

        [HttpGet("ListarAprovados")]
        public IActionResult ListarAprovados()
        {
            return Ok(_jogadorRepository.ObterAprovados());
        }
    }
}
