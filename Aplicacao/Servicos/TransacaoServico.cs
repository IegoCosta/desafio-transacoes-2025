using Aplicacao.Interfaces;
using Dominio.Entidades;
using Dominio.Repositorios;

namespace Aplicacao.Servicos
{
    public class TransacaoServico : ITransacaoServico
    {
        private readonly ITransacaoRepositorio _repositorio;

        public TransacaoServico(ITransacaoRepositorio repositorio)
        {
            _repositorio = repositorio;
        }

        public async Task CriarTransacaoAsync(Transacao transacao)
        {
            await _repositorio.CriarTransacaoAsync(transacao);
        }
    }
}
