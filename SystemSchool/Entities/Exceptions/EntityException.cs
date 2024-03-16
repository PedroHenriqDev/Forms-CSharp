using System;

namespace Entities.Expections
{
    public class EntityException : Exception
    {
        public EntityException(string message) : base(message) 
        {
        }
    }
}
