using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Classroom
    {
        public int ClassroomId { get; set; }
        public string ClassroomName { get; set; }
        public int CourseId { get; set; }

        public Classroom(int classroomId, string classroomName, int courseId)
        {
            ClassroomId = classroomId;
            ClassroomName = classroomName;
            CourseId = courseId;
        }
    }
}
