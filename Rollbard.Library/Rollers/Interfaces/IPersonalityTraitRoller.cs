using Rollbard.Library.Models;
using System.Collections.Generic;

namespace Rollbard.Library.Rollers.Interfaces
{
    public interface IPersonalityTraitRoller
    {
        Dictionary<string, List<string>> Traits { get; }
        string Get();
    }
}