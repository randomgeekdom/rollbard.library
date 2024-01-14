using Rollbard.Library.Extensions;
using Rollbard.Library.Models;
using Rollbard.Library.Rollers.Interfaces;
using System;

namespace Rollbard.Library.Rollers
{
    public class RegionNameRoller(IAdjectiveRoller adjectiveRoller, INameRoller nameRoller) : IRegionNameRoller
    {
        private readonly Random random = new Random();

        public string Get()
        {
            return Get(Biome.GetAll().GetRandom());
        }

        public string Get(Biome biome)
        {
            var name = this.random.NextBool() ? adjectiveRoller.Get() : nameRoller.GetLastName();
            return $"{name} {biome.Names.GetRandom()}";
        }
    }
}