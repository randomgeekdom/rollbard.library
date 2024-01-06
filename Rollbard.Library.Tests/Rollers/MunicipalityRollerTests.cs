using Rollbard.Library.Models;
using Rollbard.Library.Rollers;

namespace Rollbard.Library.Tests.Rollers
{
    public class MunicipalityRollerTests
    {
        private readonly MunicipalityRoller sut;

        public MunicipalityRollerTests()
        {
            sut = new MunicipalityRoller(new MunicipalityNameRoller(new NameRoller(new FantasticalNameRoller(), new RealNameRoller())));
        }

        [Fact]
        public void MunicipalityRoller_Works()
        {
            var list = new List<Municipality>();
            for (int i = 0; i < 33; i++)
            {
                list.Add(this.sut.Get());
            }

            Assert.NotEmpty(list);
        }
    }
}
