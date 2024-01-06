using Rollbard.Library.Rollers.Interfaces;
using System.Collections.Generic;

namespace Rollbard.Library.Rollers
{

    //Think Superheroes, Anime, RPGs
    public class SkillRoller : FromListRoller<string>, ISkillRoller
    {
        public override List<string> List { get; } = new List<string> {
            "Art",
            "Athletics",
            "Diplomacy",
           "Dancing",
           "Flying",
           "Hacking",
           "Ice Powers",
           "Influence",
           "Logic",
           "Marksmanship",
           "Martial Arts",
           "Melee Combat",
           "Penmanship",
           "Politics",
           "Pyrokinesis",
           "Spycraft",
           "Strategy",
           "Swordsmanship",
           "Writing",
        };
    }
}