using Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.TransientClasses
{
    public class ClassroomQuery : IResultOfQueries
    {
        public bool Result { get; set; }
        public string Message { get; set; }
        public DateTime Moment { get; set; }
        public Classroom Classroom { get; set; }

        public ClassroomQuery(bool result, string message, DateTime moment, Classroom classroom)
        {
            Result = result;
            Message = message;
            Moment = moment;
            Classroom = classroom;
        }
    }
}
