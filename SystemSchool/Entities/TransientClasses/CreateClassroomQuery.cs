using Business.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.TransientClasses
{
    public class CreateClassroomQuery : IResultOfQueries
    {
        public bool Result { get; set; }
        public string Message { get; set; }
        public DateTime Moment { get; set; }
        public Classroom Classroom { get; set; }

        public CreateClassroomQuery(bool result, string message, DateTime moment, Classroom classroom)
        {
            Result = result;
            Message = message;
            Moment = moment;
            Classroom = classroom;
        }
    }
}
