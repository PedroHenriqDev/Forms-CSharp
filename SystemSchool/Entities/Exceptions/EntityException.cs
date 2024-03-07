using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Expections
{
    public class EntityException : Exception
    {
        public EntityException(string message) : base(message) 
        {
        }
    }
}
