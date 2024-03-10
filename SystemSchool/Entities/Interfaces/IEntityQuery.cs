using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Interfaces
{
    public interface IEntityQuery<T> where T : class
    {
        bool Result { get; set; }
        string Message { get; set; }
        DateTime Moment { get; set; }
        T Value { get; set; }
    }
}
