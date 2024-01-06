using System;
using System.Collections.Generic;
using System.Text;

namespace Rollbard.Library.Models
{
    public class Municipality
    {
        public string? Name { get; set; }
        public int Population { get; set; }
        public string? Classification { get; set; }

        public override string ToString()
        {
            return $"The {Classification} of {Name} has a population of {Population}";
        }
    }
}
