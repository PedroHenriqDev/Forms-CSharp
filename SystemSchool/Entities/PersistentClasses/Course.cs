using Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Course : IEntity<Course>
    {
        public int Id {  get; set; }
        public string CourseName { get; set; }
        public DateTime DateCreation { get; set; }
        public List<Classroom> Classrooms { get; set; }

        public Course(int id, string courseName, DateTime dateCreation)
        {
            Id = id;
            CourseName = courseName;
            DateCreation = dateCreation;
        }
    }
}
