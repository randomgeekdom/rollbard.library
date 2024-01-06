using Rollbard.Library.Models;
using Rollbard.Library.Rollers.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Rollbard.Library.Rollers
{
    public static class RollerExtensions
    {
        public static IEnumerable<T> GetMany<T>(this IRoller<T> roller, int amount)
        {
            var list = new List<T>();
            
            for(int i = 0; i < amount; i++)
            {
                list.Add(roller.Get());
            }

            return list;
        }
    }
}
