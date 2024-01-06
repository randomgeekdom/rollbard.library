using Rollbard.Library.Models;
using Rollbard.Library.Rollers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rollbard.Library.Tests.Rollers
{
    public class PersonalityTraitRollerTests
    {
        [Fact]
        public void PersonlityTraits_Return()
        {
            PersonalityTraitRoller sut = new();

            Assert.NotEmpty(sut.Traits);
        }
    }
}
