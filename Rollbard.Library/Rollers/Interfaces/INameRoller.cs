using Rollbard.Library.Enumerations;
using Rollbard.Library.Models;

namespace Rollbard.Library.Rollers.Interfaces
{
    public interface INameRoller : IRoller<string>
    {
        string GetFirstName(Gender gender = Gender.Other);
        string GetLastName();
    }
}