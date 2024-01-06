using Rollbard.Library.Extensions;
using Rollbard.Library.Models;
using Rollbard.Library.Rollers.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Rollbard.Library.Rollers
{
    public class SpeciesRoller : ISpeciesRoller
    {
        private readonly Random random = new Random();

        public List<string> List { get; } = new List<string>
        {
            "Android",
            "Anthropomorph",
            "Cyborg",
            "Dragon",
            "Dwarf",
            "Elf",
            "Fairy",
            "Gnome",
            "Goblin",
            "Human",
            "Minotaur",
            "Nymph",
            "Orc",
            "Pixie",
            "Robot",
            "Siren",
            "Troll",
            "Vampire"
        };

        public Species Get()
        {
            var species = this.List.GetRandom();
            if (this.random.NextBool(10))
            {
                var secondSpecies = this.List.Where(x => x != species).GetRandom();
                return new Species($"Part {species} / Part {secondSpecies}");
            }
            else
            {
                return new Species(species);
            }
        }
    }
}