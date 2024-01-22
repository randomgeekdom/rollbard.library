namespace Rollbard.Library.Models
{
    /// <summary>
    /// A Monster is non-intelligent creature capable of causing destruction.
    /// </summary>
    /// <param name="name">The name of the monster</param>
    /// <param name="description">The description of the monster</param>
    public class Monster(string name, string description)
    {
        public string Description { get; set; } = description;
        public string Name { get; set; } = name;

        public static implicit operator string?(Monster monster)
        {
            return monster?.Name;
        }
    }
}