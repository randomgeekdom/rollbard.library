//using Rollbard.Library.Models;
//using Rollbard.Library.Rollers;

//namespace Rollbard.Library.Tests.Rollers
//{
//    public class RegionRollerTests
//    {
//        private readonly RegionRoller sut;

//        public RegionRollerTests()
//        {
//            sut = new RegionRoller(new NameRoller(new FantasticalNameRoller(), new RealNameRoller()));
//        }

//        [Fact]
//        public void RegionRoller_Works()
//        {
//            var list = new List<Region>();
//            for (int i = 0; i < 33; i++)
//            {
//                list.Add(this.sut.Get());
//            }

//            Assert.NotEmpty(list);
//        }
//    }
//}
