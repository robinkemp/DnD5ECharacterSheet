using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Threading.Tasks;
using WitchesHat.Data.Services;
using WitchesHat.Domain.Core;

namespace WitchesHat.Data.Repository
{
    public class RepositoryBase<T> where T : AggregateBase
    {
        public RepositoryBase(IMongoService mongoService)
        {
            _mongoService = mongoService;
        }

        private IMongoService _mongoService;

        public async Task<List<T>> Get()
        { 
            var collection = _mongoService.GetDatabase().GetCollection<BsonDocument> ("prayers"); // TODO get collection from type
            var documents = await collection.Find(new BsonDocument()).ToListAsync();
            var list = new List<T>();
            foreach(BsonDocument doc in documents)
            {
                list.Add(BsonSerializer.Deserialize<T>(doc));
            }   
            return list;
        }
    }
}
