using MongoDB.Driver;

namespace WitchesHat.Data.Services
{
    public interface IMongoService
    {
        MongoClient GetClient();
        IMongoDatabase GetDatabase();
    }
}