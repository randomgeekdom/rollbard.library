
using Rollbard.Library.Extensions;
using Rollbard.Library.Models;
using Rollbard.Library.Rollers.Interfaces;
using System;
using System.Linq;

namespace Rollbard.Library.Rollers
{
    public class MunicipalityNameRoller : IRoller<string>, IMunicipalityNameRoller
    {
        private readonly INameRoller nameRoller;
        private readonly Random randomizer = new Random();

        private readonly string[] prefixes = new string[]
        {
            "Saint ",
            "San ",
            "Fort ",
            "New ",
            "Old ",
            "North ",
            "South ",
            "East ",
            "West "
        };

        private readonly string[] suffixes = new string[] {
        " Town",
        " Station",
        "ville",
        "ton",
        "polis",
        " City",
        "wall",
        "grad" };

        public MunicipalityNameRoller(INameRoller nameRoller)
        {
            this.nameRoller = nameRoller;
        }

        public string Get()
        {
            var name = nameRoller.Get();
            var suffixes = this.suffixes.ToList();

            switch (randomizer.Next(3))
            {
                case 0: //suffix
                    var suffix = suffixes.GetRandom();
                    var vowels = new[] { 'a', 'e', 'i', 'o', 'u', 'y' };
                    if (!suffix.StartsWith(" ") && !(vowels.Contains(name.Last())))
                    {
                        name += vowels.GetRandom();
                    }

                    return name + suffixes.GetRandom();

                case 1: //prefix
                    return this.prefixes.GetRandom() + name;

                default:
                    return name;
            }
        }
    }
}