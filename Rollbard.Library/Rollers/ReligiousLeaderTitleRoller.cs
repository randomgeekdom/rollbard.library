using System;
using System.Collections.Generic;
using System.Text;
using Rollbard.Library.Rollers.Interfaces;

namespace Rollbard.Library.Rollers
{
    public class ReligiousLeaderTitleRoller : FromListRoller<string>, IReligiousLeaderTitleRoller
    {
        public override List<string> List { get; }
        public ReligiousLeaderTitleRoller()
        {
            this.List = new List<string> {
                "Archbishop",
                "Archdeacon",
                "Archdruid",
                "Ayatollah",
                "Elder",
                "Guru",
                "High Cleric",
                "Imam",
                "Lama",
                "Mujaddid",
                "Pope",
            };
        }
    }
}
