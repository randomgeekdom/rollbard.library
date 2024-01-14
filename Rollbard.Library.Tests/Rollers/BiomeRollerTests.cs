using Rollbard.Library.Rollers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rollbard.Library.Tests.Rollers
{
    public class BiomeRollerTests
    {
        [Fact]
        public void Get_ReturnsValue()
        {
            var result = new BiomeRoller().Get();
            Assert.NotNull(result);
        }
    }
}