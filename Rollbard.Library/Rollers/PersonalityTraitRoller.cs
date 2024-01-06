using Rollbard.Library.Extensions;
using Rollbard.Library.Models;
using Rollbard.Library.Rollers.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Rollbard.Library.Rollers
{
    /// <summary>
    /// The PersonalityTraitRoller returns a personality trait depending on genre
    /// </summary>
    public class PersonalityTraitRoller : IPersonalityTraitRoller, IRoller<string>
    {
        public Dictionary<string, List<string>> Traits { get; } = new Dictionary<string, List<string>>(); 

        public PersonalityTraitRoller()
        {
            AddToList("Ambitious", "Sedentary");
            AddToList("Courageous", "Cowardly");
            AddToList("Humorous", "Serious", "Stoic");
            AddToList("Loud", "Quiet");
        }

        private void AddToList(string trait, params string[] opposingTraits)
        {
            AddIfNotExists(trait);

            foreach (var opposingTrait in opposingTraits)
            {
                if (!Traits[trait].Contains(opposingTrait))
                {
                    this.Traits[trait].Add(opposingTrait);
                }

                AddIfNotExists(opposingTrait);
                if (!Traits[opposingTrait].Contains(trait))
                {
                    this.Traits[opposingTrait].Add(trait);
                }
            }
        }

        private List<string> AddIfNotExists(string trait)
        {
            if (!this.Traits.TryGetValue(trait, out List<string>? value))
            {
                value = new List<string>();
                Traits.Add(trait, value);
            }

            return value;
        }

        public string Get()
        {
            return this.Traits.GetRandom().Key;
        }
    }

}
