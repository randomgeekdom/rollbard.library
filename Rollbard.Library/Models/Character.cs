using Rollbard.Library.Enumerations;
using Rollbard.Library.Extensions;
using System.Collections.Generic;
using System.Linq;

namespace Rollbard.Library.Models
{
    public class Character
    {
        public string? FirstName { get; set; }
        public Gender Gender { get; set; }
        public string? Hometown { get; set; }
        public string? Job { get; set; }
        public string? LastName { get; set; }
        public string? Name => $"{FirstName} {LastName}";
        public IList<string> PersonalityTraits { get; set; } = new List<string>();
        public Species? Species { get; set; }

        public override string ToString()
        {
            var article = Job.StartsWithVowel() ? "an" : "a";
            return $"{Name} from {Hometown} is {article} {Job?.ToLower()} who is known to be {string.Join(" and ", PersonalityTraits.Select(x => x.ToLower()))}";
        }
    }
}