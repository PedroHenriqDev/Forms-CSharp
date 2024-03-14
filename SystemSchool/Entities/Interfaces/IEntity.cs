using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Interfaces
{
    public interface IEntity<T>
    {
        int Id { get; set; }
        DateTime DateCreation { get; set; }
    }
}
