using Rollbard.Library.Rollers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rollbard.Library.Tests.Rollers
{
    public class RealNameRollerTests
    {
        public RealNameRoller sut = new();

        [Fact]
        public void GetLastName_ReturnsNames()
        {
            var names = new List<string>();
            for (var i = 0; i < 10; i++)
            {
                names.Add(sut.GetLastName());
            }

            Assert.NotEmpty(names);
        }
    }
}