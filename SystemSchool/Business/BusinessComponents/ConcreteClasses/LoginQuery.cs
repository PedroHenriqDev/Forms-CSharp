using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Interfaces;
using Entities;

namespace Business.BusinessComponents.ConcreteClasses
{
    public class LoginQuery : ResultOfQueries
    {
        public bool Result { get; set; }
        public DateTime Moment { get; set; }
        public User User { get; set; }
    }
}
