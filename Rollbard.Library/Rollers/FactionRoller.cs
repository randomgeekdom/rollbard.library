using Rollbard.Library.Extensions;
using Rollbard.Library.Rollers.Interfaces;
using System;

namespace Rollbard.Library.Rollers
{
    public class FactionRoller(IAdjectiveRoller adjectiveRoller, INounRoller nounRoller) : IFactionRoller
    {
        private readonly IAdjectiveRoller adjectiveRoller = adjectiveRoller;
        private readonly INounRoller nounRoller = nounRoller;
        private readonly Random random = new();

        public string Get()
        {
            if (this.random.NextBool(4))
            {
                return $"The {adjectiveRoller.Get()} {nounRoller.Get()}";
            }

            if (this.random.NextBool())
            {
                return $"The {adjectiveRoller.Get()}";
            }
            else
            {
                return $"The {nounRoller.Get()}";
            }
        }
    }
}