using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Interfaces
{
    public interface IResultOfQueries
    {
        bool Result { get; set; }
        DateTime Moment { get; set; }
    }
}
