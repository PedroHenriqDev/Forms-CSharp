using Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.TransientClasses
{
    public class CourseQuery : IResultOfQueries
    {
        public bool Result { get; set; }
        public string Message {  get; set; }
        public DateTime Moment { get; set; }
        public  Course Course { get; set; }

        public CourseQuery(bool result, string message, DateTime moment, Course course) 
        {
            Result = result;
            Message = message;
            Moment = moment;
            Course = course;
        }
    }
}
