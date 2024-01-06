namespace Rollbard.Library.Models
{
    public class Title
    {
        public Title()
        { }

        public Title(string name) : this(name, name)
        {
        }

        public Title(string name, string honorific)
        {
            this.Name = name;
            this.Honorific = honorific;
        }

        public string? Honorific { get; set; }
        public string? Name { get; set; }
    }
}