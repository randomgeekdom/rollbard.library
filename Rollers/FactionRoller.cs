using Rollbard.Library.Rollers.Interfaces;

namespace Rollbard.Library.Rollers
{
    public class FactionRoller : IFactionRoller
    {
        private readonly IAdjectiveRoller adjectiveRoller;
        private readonly INounRoller nounRoller;

        public FactionRoller(IAdjectiveRoller adjectiveRoller, INounRoller nounRoller)
        {
            this.adjectiveRoller = adjectiveRoller;
            this.nounRoller = nounRoller;
        }

        public string Get()
        {
            return $"The {adjectiveRoller.Get()} {nounRoller.Get()}";
        }
    }
}