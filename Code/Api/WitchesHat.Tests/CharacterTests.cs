using System;
using WitchesHat.Domain.Character;
using Xunit;

namespace WitchesHat.Tests
{
    public class CharacterTests
    {
        [Fact]
        public void Create_WithEmptyCharacterId_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => Character.Create(Guid.Empty, "Name"));
        }

        [Fact]
        public void Create_WithEmptyCharacterName_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => Character.Create(Guid.NewGuid(), string.Empty));
        }
    }
}
