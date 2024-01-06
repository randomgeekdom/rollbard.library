using System;
using System.Collections.Generic;
using System.Text;

namespace Rollbard.Library.Models
{
    public class Species
    {
        public Species(string name)
        {
            this.Name = name;
        }

        public string Name { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}