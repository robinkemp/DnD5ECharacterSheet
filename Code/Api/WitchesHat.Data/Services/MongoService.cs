using MongoDB.Bson.Serialization.Conventions;
using MongoDB.Driver;

namespace WitchesHat.Data.Services
{
    public class MongoService : IMongoService
    {
        public MongoService(string cluster, string database, string username, string password)
        {
            _connectionString = $"mongodb+srv://{username}:{password}@{cluster}/{database}?retryWrites=true&w=majority";
            _database = database;
        }

        private readonly string _connectionString;
        private readonly string _database;

        public MongoClient GetClient()
        { 
            var conventionPack = new ConventionPack { 
                new IgnoreExtraElementsConvention(true), 
                new CamelCaseElementNameConvention() 
            };
            ConventionRegistry.Register("EssentialConfig", conventionPack, type => true);
            return new MongoClient(_connectionString);
        }

        public IMongoDatabase GetDatabase()
        { 
            return GetClient().GetDatabase(_database);
        }
    }
}
