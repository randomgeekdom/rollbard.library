using Rollbard.Library.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Rollbard.Library.Rollers.Interfaces
{
    public interface IRegionNameRoller : IRoller<string>
    {
        string Get(Biome biome);
    }
}