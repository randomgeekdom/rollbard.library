using Rollbard.Library.Extensions;
using Rollbard.Library.Models;
using Rollbard.Library.Rollers.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Rollbard.Library.Rollers
{
    public class MunicipalityRoller : IRoller<Municipality>, IMunicipalityRoller
    {
        private readonly IMunicipalityNameRoller cityNameRoller;
        private readonly Random random = new Random();

        public MunicipalityRoller(IMunicipalityNameRoller cityNameRoller)
        {
            this.cityNameRoller = cityNameRoller;
        }

        public Municipality Get()
        {
            var municipality = new Municipality
            {
                Name = this.cityNameRoller.Get(),
                Population = this.random.Next(25, this.ClassificationPopulation.GetRandom().Value * 2)
            };

            municipality.Classification = ClassificationPopulation.First(x => x.Value < municipality.Population).Key;

            return municipality;
        }


        private Dictionary<string, int> ClassificationPopulation = new Dictionary<string, int> {
            {"Megalopolis",  25000000},
            {"Metropolis",  100000},
            {"City",  50000},
            {"Township",  10000},
            {"Town",  5000},
            {"Village",  25},
        };
    }
}