using CSharpFunctionalExtensions;
using System.Threading.Tasks;

namespace WitchesHat.Data.Repository.Player
{
    public interface IPlayerRepository : IRepositoryBase<Domain.Player.Player>
    {
        Task<Result<Domain.Player.Player>> GetPlayerFromSub(string sub);
    }
}