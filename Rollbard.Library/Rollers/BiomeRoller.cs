using System;
using System.Collections.Generic;
using System.Text;
using Rollbard.Library.Rollers.Interfaces;

namespace Rollbard.Library.Rollers
{
    /// <summary>
    /// The list of biomes or region types that determine the general climate of a region
    /// </summary>
    public class BiomeRoller : FromListRoller<string>, IBiomeRoller
    {
        public override List<string> List { get; } = new List<string> {
            "Desert",
            "Grassland",
            "Hills",
            "Forest",
            "Island",
            "Jungle",
            "Mountains",
            "Swampland",
            "Tundra"
            };
    }
}