using Rollbard.Library.Models;

namespace Rollbard.Library.Rollers.Interfaces
{
    public interface IRoller<T>
    {
        T Get();
    }
}