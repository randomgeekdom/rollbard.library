using Rollbard.Library.Enumerations;

namespace Rollbard.Library.Rollers.Interfaces
{
    public interface IRealNameRoller
    {
        string GetFirstName(Gender gender = Gender.Other);
        string GetLastName();
    }
}