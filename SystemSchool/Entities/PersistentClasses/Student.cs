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
        public int ClassroomId {  get; set; }
        public Classroom Classroom { get; set; }
        public string CompleteName {  get; set; }

        public Student(int studentId, int classroomId, string completeName )
        {
            StudentId = studentId;
            ClassroomId = classroomId;
            CompleteName = completeName;
        }
    }
}
