//using Rollbard.Library.Extensions;
//using Rollbard.Library.Models;
//using Rollbard.Library.Rollers.Interfaces;
//using System;
//using System.Collections.Generic;
//using System.Linq;

//namespace Rollbard.Library.Rollers
//{
//    public class RegionRoller : IRoller<Region>, IRegionRoller
//    {
//        public RegionRoller(INameRoller nameRoller)
//        {
//            this.nameRoller = nameRoller;
//        }

//        public Region Get()
//        {
//            Region? region = null;
//            while (region == null)
//            {
//                var climate = EnumExtensions.GetRandom<RegionClimate>();
//                var humidity = EnumExtensions.GetRandom<RegionHumidity>();
//                var terrain = EnumExtensions.GetRandom<Terrain>();

//                var filtered = _regions.Where(x =>
//                    x.Item2.Contains(humidity) &&
//                    x.Item3.Contains(climate) &&
//                    x.Item4.Contains(terrain));

//                if (filtered.Any())
//                {
//                    region = new Region
//                    {
//                        Climate = climate,
//                        Humidity = humidity,
//                        Terrain = terrain,
//                        Name = $"{this.nameRoller.Get()} {filtered.GetRandom().Item1}"
//                    };
//                }
//            }

//            return region;
//        }

//        public string GetName()
//        {
//            return $"{this.nameRoller.Get()} {this._regions.OrderBy(x=>Guid.NewGuid()).First().Item1}";
//        }

//        private IEnumerable<(string, IEnumerable<RegionHumidity>, IEnumerable<RegionClimate>, IEnumerable<Terrain>)> _regions = new List<(string, IEnumerable<RegionHumidity>, IEnumerable<RegionClimate>, IEnumerable<Terrain>)>
//        {
//            ("Badlands", new List<RegionHumidity> {RegionHumidity.Arid}, new List<RegionClimate>{RegionClimate.Hot}, new List<Terrain>{Terrain.Flatlands, Terrain.Hills, Terrain.Mountains }),
//            ("Bayou", new List<RegionHumidity> {RegionHumidity.Humid}, new List<RegionClimate>{RegionClimate.Hot}, new List<Terrain>{Terrain.Wetlands }),
//            ("Bog", new List<RegionHumidity> {RegionHumidity.Arid, RegionHumidity.Humid}, new List<RegionClimate>{RegionClimate.Cold, RegionClimate.Temperate}, new List<Terrain>{Terrain.Wetlands }),
//            ("Desert", new List<RegionHumidity> {RegionHumidity.Arid}, new List<RegionClimate>{RegionClimate.Hot}, new List<Terrain>{Terrain.Flatlands, Terrain.Hills }),
//            ("Forest", new List<RegionHumidity> {RegionHumidity.Arid}, new List<RegionClimate>{RegionClimate.Cold, RegionClimate.Temperate, RegionClimate.Hot}, new List<Terrain>{ Terrain.Forest }),
//            ("Island", new List<RegionHumidity> {RegionHumidity.Arid, RegionHumidity.Arid}, new List<RegionClimate>{RegionClimate.Hot, RegionClimate.Temperate, RegionClimate.Cold}, new List<Terrain>{Terrain.Island }),
//            ("Isle", new List<RegionHumidity> {RegionHumidity.Arid, RegionHumidity.Arid}, new List<RegionClimate>{RegionClimate.Hot, RegionClimate.Temperate, RegionClimate.Cold}, new List<Terrain>{Terrain.Island }),
//            ("Frostlands", new List<RegionHumidity> {RegionHumidity.Arid}, new List<RegionClimate>{RegionClimate.Cold}, new List<Terrain>{Terrain.Flatlands, Terrain.Hills }),
//            ("Marsh", new List<RegionHumidity> {RegionHumidity.Humid}, new List<RegionClimate>{RegionClimate.Hot}, new List<Terrain>{Terrain.Wetlands }),
//            ("Marshlands", new List<RegionHumidity> {RegionHumidity.Humid}, new List<RegionClimate>{RegionClimate.Hot}, new List<Terrain>{Terrain.Wetlands }),
//            ("Mountains", new List<RegionHumidity> {RegionHumidity.Arid, RegionHumidity.Humid}, new List<RegionClimate>{RegionClimate.Cold, RegionClimate.Temperate, RegionClimate.Hot}, new List<Terrain>{Terrain.Mountains }),
//            ("Oasis", new List<RegionHumidity> {RegionHumidity.Arid}, new List<RegionClimate>{RegionClimate.Hot, RegionClimate.Temperate}, new List<Terrain>{Terrain.Wetlands}),
//            ("Plains", new List<RegionHumidity> {RegionHumidity.Arid}, new List<RegionClimate>{RegionClimate.Temperate}, new List<Terrain>{Terrain.Flatlands }),
//            ("Range", new List<RegionHumidity> {RegionHumidity.Arid, RegionHumidity.Humid}, new List<RegionClimate>{RegionClimate.Cold, RegionClimate.Temperate, RegionClimate.Hot}, new List<Terrain>{Terrain.Mountains }),
//            ("Savanna", new List<RegionHumidity> {RegionHumidity.Humid}, new List<RegionClimate>{RegionClimate.Temperate, RegionClimate.Hot}, new List<Terrain>{Terrain.Flatlands }),
//            ("Swamp", new List<RegionHumidity> {RegionHumidity.Humid}, new List<RegionClimate>{RegionClimate.Hot}, new List<Terrain>{Terrain.Wetlands }),
//            ("Swamplands", new List<RegionHumidity> {RegionHumidity.Humid}, new List<RegionClimate>{RegionClimate.Hot}, new List<Terrain>{Terrain.Wetlands }),
//            ("Woods", new List<RegionHumidity> {RegionHumidity.Arid}, new List<RegionClimate>{RegionClimate.Cold, RegionClimate.Temperate, RegionClimate.Hot}, new List<Terrain>{ Terrain.Forest }),
//        };
//        private readonly INameRoller nameRoller;
//    }
//}