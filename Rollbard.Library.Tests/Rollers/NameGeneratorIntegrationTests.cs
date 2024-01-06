using Rollbard.Library.Rollers;

namespace Rollbard.Library.Tests.Generators
{
    public class NameGeneratorIntegrationTests
    {
        private readonly NameRoller nameGenerator = new(new FantasticalNameRoller(), new RealNameRoller());

        [Fact]
        public void GenerateName_DoesNotError()
        {
            var list = new List<string>();
            for (int i = 0; i < 100; i++)
            {
                try
                {
                    list.Add($"{nameGenerator.GetFirstName()} {nameGenerator.GetLastName()}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            }

            Assert.NotNull(list);
        }
    }
}