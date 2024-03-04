using Business.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.TransientClasses
{
    public class CreateCourseQuery : IResultOfQueries
    {
        public bool Result { get; set; }
        public string Message {  get; set; }
        public DateTime Moment { get; set; }
        public  Course Course { get; set; }

        public CreateCourseQuery(bool result, string message, DateTime moment, Course course) 
        {
            Result = result;
            Message = message;
            Moment = moment;
            Course = course;
        }
    }
}
