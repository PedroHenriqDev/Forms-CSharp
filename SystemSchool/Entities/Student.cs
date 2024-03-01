using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Student
    {
        public int StudentId { get; set; }
        public string ClassroomId {  get; set; }
        public Classroom Classroom { get; set; }
        public string CompleteName {  get; set; }
    }
}
