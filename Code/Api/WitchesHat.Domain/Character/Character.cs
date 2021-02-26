using System;
using WitchesHat.Domain.Core;

namespace WitchesHat.Domain.Character
{
    public class Character : AggregateBase
    {
        private Character(Guid chracterId,
            string characterName)
        {
            CharacterId = chracterId;
            CharacterName = characterName;
        }

        public Guid CharacterId { get; private set; }
        public string CharacterName { get; private set; }

        public static Character Create(Guid chracterId,
            string characterName)
        { 
            if(chracterId == Guid.Empty)
            { 
                throw new ArgumentException("CharacterId must not be empty");
            }

            if(string.IsNullOrWhiteSpace(characterName))
            { 
                throw new ArgumentException("CharacterName must not be empty");
            }

            return new Character(chracterId,
                characterName);
        }
    }
}
