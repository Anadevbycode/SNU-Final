using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SNU.Servico;

namespace SNU.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlunoController : ControllerBase
    {
        private readonly IAlunoServico _servico;

        public AlunoController(IAlunoServico servico)
        {
            _servico = servico;
        }

        [HttpPost]
        public IActionResult Adicionar(AlunoDto alunoDto)
        {
            _servico.Adicionar(alunoDto);
            return Ok(new { mensagem = "Aluno adicionado com sucesso" });
        }

        [HttpGet]
        public IActionResult Listar()
        {
            return Ok(new { alunos = _servico.Listar() });
        }
    }
}