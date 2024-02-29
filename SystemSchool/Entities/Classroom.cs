using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    internal class Classroom
    {
        public int ClassroomId { get; set; }
        public string ClassroomName { get; set; }
        public int CourseId { get; set; }
        public Course Course { get; set; }
        public int ClassId { get; set; }
        public Class Class { get; set; }
        public List<Student> Students { get; set; }
    }
}
