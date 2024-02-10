using Rollbard.Library.Enumerations;
using Rollbard.Library.Extensions;
using Rollbard.Library.Resources;
using Rollbard.Library.Rollers.Interfaces;
using System;

namespace Rollbard.Library.Rollers
{
    public class RealNameRoller : IRealNameRoller
    {
        private readonly Random random = new();

        public string GetFirstName(Gender gender = Gender.Other)
        {
            return gender switch
            {
                Gender.Male => Names.GetMaleFirstNames().GetRandom(),
                Gender.Female => Names.GetFemaleFirstNames().GetRandom(),
                _ => random.NextBool() ? Names.GetMaleFirstNames().GetRandom() : Names.GetFemaleFirstNames().GetRandom(),
            };
        }

        public string GetLastName()
        {
            return Names.GetLastNames().GetRandom();
        }
    }
}