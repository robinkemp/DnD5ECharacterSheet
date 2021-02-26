using WitchesHat.Data.Services;

namespace WitchesHat.Data.Repository.Character
{
    public class CharacterRepository : RepositoryBase<WitchesHat.Domain.Character.Character>, ICharacterRepository
    {
        public CharacterRepository(IMongoService mongoService) : base(mongoService)
        {
        }
    }
}
