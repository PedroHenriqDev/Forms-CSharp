using Business.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.TransientClasses
{
    public class CreateStudentQuery : IResultOfQueries
    {
        public bool Result { get; set; }
        public string Message { get; set; }
        public DateTime Moment { get; set; }
        public Student Student { get; set; }

        public CreateStudentQuery(bool result, string message, DateTime moment, Student student)
        {
            Result = result;
            Message = message;
            Moment = moment;
            Student = student;
        }
    }
}
