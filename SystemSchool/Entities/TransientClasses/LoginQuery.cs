using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Interfaces;
using Entities;

namespace Business.BusinessComponents.ConcreteClasses
{
    public class LoginQuery : IResultOfQueries
    {
        public bool Result { get; set; }
        public string Message { get; set; }
        public DateTime Moment { get; set; }
        public User User { get; set; }

        public LoginQuery(bool result, string message, DateTime moment, User user) 
        {
            Result = result;
            Message = message;
            Moment = moment;
            User = user;
        }
    }
}
