using Rollbard.Library.Models;
using Rollbard.Library.Rollers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rollbard.Library.Tests.Rollers
{
    public class CharacterRollerTests
    {
        [Fact]
        public void RollCharacter_Functions()
        {
            var fantasticalNameRoller = new FantasticalNameRoller();
            var nameRoller = new NameRoller(fantasticalNameRoller, new RealNameRoller());
            var sut = new CharacterRoller(nameRoller, new MunicipalityNameRoller(nameRoller), new JobRoller(), new PersonalityTraitRoller(), new SpeciesRoller());

            var characters = new List<Character>();

            for(int i = 0; i<17;i++)
            {
                characters.Add(sut.Get());
            }

            Assert.NotEmpty(characters);
        }
    }
}
