using System;

namespace Entities.Interfaces
{
    public interface IEntity<T>
    {
        int Id { get; set; }
        DateTime DateCreation { get; set; }
    }
}
