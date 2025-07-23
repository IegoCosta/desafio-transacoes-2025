using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Dominio.Entidades
{
    public class Transacao
    {
        [BsonId]
        public ObjectId Id { get; set; }

        [BsonElement("descricao")]
        public string Descricao { get; set; }

        [BsonElement("valor")]
        public decimal Valor { get; set; }

        [BsonElement("data")]
        public DateTime Data { get; set; }
    }
}
