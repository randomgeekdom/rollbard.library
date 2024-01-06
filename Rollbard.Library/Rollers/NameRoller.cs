using Rollbard.Library.Enumerations;
using Rollbard.Library.Extensions;
using Rollbard.Library.Rollers.Interfaces;
using System;

namespace Rollbard.Library.Rollers
{
    public class NameRoller : INameRoller
    {
        private readonly IFantasticalNameRoller fantasticalNameRoller;
        private readonly IRealNameRoller realNameRoller;
        private readonly Random random = new Random();

        public NameRoller(IFantasticalNameRoller fantasticalNameRoller, IRealNameRoller realNameRoller)
        {
            this.fantasticalNameRoller = fantasticalNameRoller;
            this.realNameRoller = realNameRoller;
        }

        public string Get()
        {
            return random.NextBool() ? GetFirstName() : GetLastName();
        }

        public string GetFirstName(Gender gender = Gender.Other)
        {
            int fantasticalNamePercentage = 25;

            if (random.NextBool(fantasticalNamePercentage))
            {
                return fantasticalNameRoller.Get();
            }
            else
            {
                return realNameRoller.GetFirstName(gender);
            }
        }

        public string GetLastName()
        {
            int fantasticalNamePercentage = 25;
            if (random.NextBool(fantasticalNamePercentage))
            {
                return fantasticalNameRoller.Get();
            }
            else
            {
                return realNameRoller.GetLastName();
            }
        }
    }
}