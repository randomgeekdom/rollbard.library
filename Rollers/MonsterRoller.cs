using Rollbard.Library.Models;
using Rollbard.Library.Rollers.Interfaces;
using System.Collections.Generic;

namespace Rollbard.Library.Rollers
{
    /// <summary>
    /// A roller to generate monsters that can be found in a fantastical setting
    /// </summary>
    public class MonsterRoller : FromListRoller<Monster>, IMonsterRoller
    {
        public override List<Monster> List { get; } = new List<Monster> 
        {
            new Monster("Demon", "A being from the infernal realms.  Several species and varieties exist."),
            new Monster("Dragon", "A giant lizard that can fly and breathe fire."),
            new Monster("Fire Monster", "A creature made of flames."),
            new Monster("Flying Serpent", "A snake that is large and can fly despite not having wings."),
            new Monster("Giant", "A humanoid of gigantic proportions"),
            new Monster("Golem", "A clay construct that were once guardians but have gone rogue."),
            new Monster("Griffin", "A creature with the head and wings of an eagle and the body of a lion."),
            new Monster("Troll", "A giant monstrosity that ravages all it sees."),
            new Monster("Werewolf", "A creature that looks like a giant wolf but was once a normal person."),
            new Monster("Tyrannosaurus", "A carnivorous dinosaur.")
        };
    }
}