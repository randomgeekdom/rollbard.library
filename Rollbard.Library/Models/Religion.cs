using System.Collections.Generic;

namespace Rollbard.Library.Models
{

    public class Religion
    {
        public string? Name { get; set; }
        public IEnumerable<Title> ClericTitles { get; set; } = new List<Title>();
        public string? CreationMyth { get; set; }
        public IEnumerable<Deity> Deities { get; set; } = new List<Deity>();
        public IEnumerable<MysticalCreature> Creatures { get; set; } = new List<MysticalCreature>();
        public DeityType DeityType { get; set; }
        public Title? LeaderTitle { get; set; }
        public IEnumerable<ReligiousFigure> ImportantFigures { get; set; } = new List<ReligiousFigure>();
        public string? HolyBook { get; set; }
    }
}