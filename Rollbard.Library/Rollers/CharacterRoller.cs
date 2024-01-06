using Rollbard.Library.Enumerations;
using Rollbard.Library.Extensions;
using Rollbard.Library.Models;
using Rollbard.Library.Rollers.Interfaces;
using System;
using System.Linq;

namespace Rollbard.Library.Rollers
{
    public class CharacterRoller : ICharacterRoller
    {
        private readonly IMunicipalityNameRoller cityNameRoller;
        private readonly IJobRoller jobRoller;
        private readonly INameRoller nameRoller;
        private readonly IPersonalityTraitRoller personalityTraitRoller;
        private readonly ISpeciesRoller speciesRoller;
        private readonly Random random = new Random();

        public CharacterRoller(INameRoller nameRoller, IMunicipalityNameRoller cityNameRoller, IJobRoller jobRoller, IPersonalityTraitRoller personalityTraitRoller, ISpeciesRoller speciesRoller)
        {
            this.nameRoller = nameRoller;
            this.cityNameRoller = cityNameRoller;
            this.jobRoller = jobRoller;
            this.personalityTraitRoller = personalityTraitRoller;
            this.speciesRoller = speciesRoller;
        }

        public Character Get()
        {
            var gender = this.random.NextBool(1) ? Gender.Other : (this.random.NextBool() ? Gender.Female : Gender.Male);
            var character = new Character
            {
                FirstName = this.nameRoller.GetFirstName(gender),
                LastName = this.nameRoller.GetLastName(),
                Hometown = this.cityNameRoller.Get(),
                Job = this.jobRoller.Get(),
                Gender = gender,
                Species = this.speciesRoller.Get()
            };

            for (int i = 0; i < 2; i++)
            {
                var trait = this.personalityTraitRoller.Get();
                if (!character.PersonalityTraits.Any(x => this.personalityTraitRoller.Traits[trait].Any(y => x == y)))
                {
                    if (!character.PersonalityTraits.Contains(trait))
                    {
                        character.PersonalityTraits.Add(trait);
                    }
                }
            }

            return character;
        }
    }
}