using CSharpFunctionalExtensions;
using System.Threading.Tasks;
using WitchesHat.Data.Services;

namespace WitchesHat.Data.Repository.Player
{
    public class PlayerRepository : RepositoryBase<Domain.Player.Player>, IPlayerRepository
    {
        public PlayerRepository(IMongoService mongoService) : base(mongoService, "players")
        {
        }

        public async Task<Result<Domain.Player.Player>> GetPlayerFromSub(string sub)
        { 
            return await GetSingle("sub", sub);    
        }
    }
}
