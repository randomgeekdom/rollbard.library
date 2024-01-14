using Rollbard.Library.Rollers;

namespace Rollbard.Library.Tests.Rollers
{
    public class RegionNameRollerTests
    {
        [Fact]
        public void Get_ReturnsValue()
        {
            var sut = new RegionNameRoller(new AdjectiveRoller(), new NameRoller(new FantasticalNameRoller(), new RealNameRoller()));

            var result = sut.Get();

            Assert.NotNull(result);
        }
    }
}