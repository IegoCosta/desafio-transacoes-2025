using Microsoft.Extensions.Configuration;
using MongoDB.Driver;
using Dominio.Entidades;

namespace Infraestrutura.Contexto
{
    public class MongoDbContexto
    {
        private readonly IMongoDatabase _banco;

        public MongoDbContexto(IConfiguration config)
        {
            var cliente = new MongoClient(config.GetConnectionString("MongoDb"));
            _banco = cliente.GetDatabase("TransacoesDB");
        }

        public IMongoCollection<Transacao> Transacoes =>
            _banco.GetCollection<Transacao>("Transacoes");
    }
}
