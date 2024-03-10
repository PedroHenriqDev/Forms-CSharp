using Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Classroom : IEntity<Classroom>
    {
        public int Id { get; set; }
        public string ClassroomName { get; set; }
        public int CourseId { get; set; }
        public Course Course { get; set; }

        public Classroom(int id, string classroomName, int courseId)
        {
            Id = id;
            ClassroomName = classroomName;
            CourseId = courseId;
        }
    }
}
