using Rollbard.Library.Extensions;
using Rollbard.Library.Models;
using Rollbard.Library.Rollers.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Rollbard.Library.Rollers
{
    public abstract class FromListRoller<T> : IRoller<T>
    {
        public abstract List<T> List { get; }

        public T Get()
        {
            return List.GetRandom();
        }
    }
}