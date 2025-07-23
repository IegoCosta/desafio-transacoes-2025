using Dominio.Entidades;

namespace Aplicacao.Interfaces
{
    public interface ITransacaoServico
    {
        Task CriarTransacaoAsync(Transacao transacao);
    }
}
