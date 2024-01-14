using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Rollbard.Library.Models;
using Rollbard.Library.Rollers.Interfaces;

namespace Rollbard.Library.Rollers
{
    /// <summary>
    /// The list of biomes or region types that determine the general climate of a region
    /// </summary>
    public class BiomeRoller : FromListRoller<Biome>, IBiomeRoller
    {
        public override List<Biome> List { get; } = [.. Biome.GetAll()];
    }
}