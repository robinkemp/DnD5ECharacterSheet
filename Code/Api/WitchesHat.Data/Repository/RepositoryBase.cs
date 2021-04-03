using CSharpFunctionalExtensions;
using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using WitchesHat.Data.Services;
using WitchesHat.Domain.Core;

namespace WitchesHat.Data.Repository
{
    public class RepositoryBase<T> where T : AggregateBase
    {
        public RepositoryBase(IMongoService mongoService, string collection)
        {
            _mongoService = mongoService;
            _collection = collection;
        }

        private IMongoService _mongoService;
        private readonly string _collection;

        public async Task<List<T>> Get()
        { 
            var collection = _mongoService.GetDatabase().GetCollection<BsonDocument> (_collection);
            var documents = await collection.Find(new BsonDocument()).ToListAsync();
            var list = new List<T>();
            foreach(BsonDocument doc in documents)
            {
                list.Add(BsonSerializer.Deserialize<T>(doc));
            }   
            return list;
        }

        public async Task<Result<T>> GetSingle(string filterField, object filterValue)
        { 
            var collection = _mongoService.GetDatabase().GetCollection<BsonDocument> (_collection);
            var filter = Builders<BsonDocument>.Filter.Eq(filterField, filterValue);
            var document = await collection.Find(filter).FirstOrDefaultAsync();
            return Result.SuccessIf(document != null, 
                (document == null) ? null : BsonSerializer.Deserialize<T>(document),
                (document == null) ? "No document found" : string.Empty);
        }

        public async Task<Result<T>> Create(T newItem)
        {
            try
            {
                var collection = _mongoService.GetDatabase().GetCollection<BsonDocument> (_collection);
                newItem.Id = null;
                var document = newItem.ToBsonDocument();
                document["_id"] = ObjectId.GenerateNewId();
                await collection.InsertOneAsync(document, new InsertOneOptions(), new CancellationToken());
                newItem.Id = document["_id"].ToString();
                return Result.Success<T>(newItem);
            }
            catch (System.Exception ex)
            {
                return Result.Failure<T>($"Create failed: {ex.Message}");
            }
            
        }
    }
}