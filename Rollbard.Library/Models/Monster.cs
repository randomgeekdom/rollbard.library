using System;
using System.Collections.Generic;
using System.Text;

namespace Rollbard.Library.Models
{
    public class Monster
    {
        public Monster(string name, string description)
        {
            this.Name = name;
            this.Description = description;
        }

        public string Description { get; set; }
        public string Name { get; set; }

        public static implicit operator string?(Monster monster)
        {
            return monster?.Name;
        }
    }
}