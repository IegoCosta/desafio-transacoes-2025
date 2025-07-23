using Dominio.Entidades;

namespace Dominio.Repositorios
{
    public interface ITransacaoRepositorio
    {
        Task CriarTransacaoAsync(Transacao transacao);
    }
}
