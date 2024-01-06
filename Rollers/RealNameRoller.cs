using RandomNameGeneratorLibrary;
using Rollbard.Library.Enumerations;
using Rollbard.Library.Rollers.Interfaces;
using System;

namespace Rollbard.Library.Rollers
{
    public class RealNameRoller : IRealNameRoller
    {
        private readonly PersonNameGenerator realNameGenerator;

        public RealNameRoller()
        {
            this.realNameGenerator = new PersonNameGenerator();
        }

        public string GetFirstName(Gender gender = Gender.Other)
        {
            return gender switch
            {
                Gender.Male => this.realNameGenerator.GenerateRandomMaleFirstName(),
                Gender.Female => this.realNameGenerator.GenerateRandomFemaleFirstName(),
                _ => this.realNameGenerator.GenerateRandomFirstName(),
            };
        }

        public string GetLastName()
        {
            return this.realNameGenerator.GenerateRandomLastName();
        }
    }
}