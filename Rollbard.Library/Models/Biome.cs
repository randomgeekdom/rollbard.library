using System.Linq;

namespace Rollbard.Library.Models
{
    public class Biome(string text, params string[] names)
    {
        public static Biome Archipelago = new(nameof(Archipelago), "Archipelago", "Islands", "Isles");
        public static Biome Desert = new(nameof(Desert), "Badlands", "Desert", "Dunes", "Oasis");
        public static Biome Forest = new(nameof(Forest), "Forest", "Wood", "Woods");
        public static Biome Grassland = new(nameof(Grassland), "Grassland", "Grasslands", "Plains", "Savanna");
        public static Biome Hills = new(nameof(Hills), "Hills");
        public static Biome Island = new(nameof(Island), "Island", "Isle");
        public static Biome Jungle = new(nameof(Jungle), "Jungle", "Rainforest");
        public static Biome Mountains = new(nameof(Mountains), "Mountains", "Range", "Sierra");
        public static Biome Swampland = new(nameof(Swampland), "Bayou", "Bog", "Marsh", "Marshland", "Marshlands", "Swamp", "Swampland", "Swamplands");
        public static Biome Tundra = new(nameof(Tundra), "Forest", "Frostland", "Frostlands", "Snowfield", "Snowfields", "Tundra");
        public string[] Names { get; } = names;

        public string Text { get; } = text;

        public static Biome[] GetAll()
        {
            return typeof(Biome).GetFields(System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.Public).Select(x => x.GetValue(null)).Cast<Biome>().ToArray();
        }

        public static implicit operator string?(Biome biome)
        {
            return biome?.Text;
        }

        public override string ToString()
        {
            return Text;
        }
    }
}