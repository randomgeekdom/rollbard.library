using Rollbard.Library.Rollers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rollbard.Library.Tests.Rollers
{
    public class FactionRollerTests
    {
        [Fact]
        public void Get_Succeeds()
        {
            var sut = new FactionRoller(new AdjectiveRoller(), new NounRoller());

            var list = new List<string>();
            for (int i = 0; i < 10; i++)
            {
                list.Add(sut.Get());
            }

            Assert.All(list, Assert.NotEmpty);
        }

    }
}
