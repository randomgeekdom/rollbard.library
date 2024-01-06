
//unit tests
using Rollbard.Library.Rollers;

namespace Rollbard.Library.Tests.Generators
{
    public class FantasticalNameGeneratorTests
    {
        [Fact]
        public void FantasticalNameGenerator_DoesNotError()
        {
            var generator = new FantasticalNameRoller();
            var list = new List<string>();
            for (int i = 0; i < 100; i++)
            {
                list.Add(generator.Get());
            }

            Assert.True(list.Count == 100);
        }
    }
}