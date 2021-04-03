using WitchesHat.Domain.Core;

namespace WitchesHat.Domain.Player
{
    public class Player : AggregateBase
    {
        public string Sub { get; set; }
        public string Nickname { get; set; }
    }
}
