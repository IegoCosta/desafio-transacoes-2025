using Dominio.Entidades;
using Dominio.Repositorios;
using Infraestrutura.Contexto;
using MongoDB.Driver;

namespace Infraestrutura.Repositorios
{
    public class TransacaoRepositorio : ITransacaoRepositorio
    {
        private readonly MongoDbContexto _contexto;

        public TransacaoRepositorio(MongoDbContexto contexto)
        {
            _contexto = contexto;
        }

        public async Task CriarTransacaoAsync(Transacao transacao)
        {
            await _contexto.Transacoes.InsertOneAsync(transacao);
        }
    }
}
