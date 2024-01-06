using Microsoft.VisualStudio.TestPlatform.ObjectModel.Utilities;
using Rollbard.Library.Rollers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rollbard.Library.Tests.Generators
{
    public class CityNameGeneratorIntegrationTests
    {
        private readonly NameRoller nameGenerator = new(new FantasticalNameRoller(), new RealNameRoller());

        private readonly MunicipalityNameRoller cityNameRoller;

        public CityNameGeneratorIntegrationTests()
        {
            cityNameRoller = new MunicipalityNameRoller(nameGenerator);
        }

        [Fact]
        public void GenerateName_DoesNotError() 
        {
            var list = new List<string>();
            for(int i = 0; i < 100; i++)
            {
                list.Add($"{cityNameRoller.Get()}");
            }

            Assert.NotNull(list);
        }
    }
}
