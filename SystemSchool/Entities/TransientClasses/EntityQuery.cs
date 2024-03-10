using Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.TransientClasses
{
    public class EntityQuery<T> : IEntityQuery<T> where T : class, IEntity<T>
    {
        public bool Result { get; set; }
        public string Message { get; set; }
        public DateTime Moment { get; set; }
        public T Value { get; set; }

        public EntityQuery(bool result, string message, DateTime moment, T value) 
        {
            Result = result;
            Message = message;
            Moment = moment;
            Value = value;
        }
    }
}
