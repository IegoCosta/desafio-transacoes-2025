using Aplicacao.Interfaces;
using Dominio.Entidades;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TransacoesController : ControllerBase
    {
        private readonly ITransacaoServico _servico;

        public TransacoesController(ITransacaoServico servico)
        {
            _servico = servico;
        }

        [HttpPost]
        public async Task<IActionResult> Criar([FromBody] Transacao transacao)
        {
            await _servico.CriarTransacaoAsync(transacao);
            return Ok(new { mensagem = "Transação criada com sucesso!" });
        }
    }
}
