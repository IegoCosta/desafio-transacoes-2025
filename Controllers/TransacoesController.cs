using Microsoft.AspNetCore.Mvc;

namespace TransacoesService.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TransacoesController : ControllerBase
    {
        // GET: api/transacoes
        [HttpGet]
        public IActionResult GetTransacoes()
        {
            // Retorna lista mockada
            var transacoes = new[]
            {
                new { Id = 1, Valor = 100.50, Tipo = "Credito" },
                new { Id = 2, Valor = 50.75, Tipo = "Debito" }
            };

            return Ok(transacoes);
        }
    }
}
