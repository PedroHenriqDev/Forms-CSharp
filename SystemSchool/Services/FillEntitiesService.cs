using Datas;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Services.Exceptions;

namespace Services
{
    public class FillEntitiesService
    {

        private readonly SearchEntitiesService _searchEntities;

        public FillEntitiesService(SearchEntitiesService searchEntities)
        {
            _searchEntities = searchEntities;
        }

        public async Task FillCourseInClassroomAsync(IEnumerable<Classroom> classrooms)
        {
            if (classrooms.Any())
            {
                foreach (var classroom in classrooms)
                {
                    if (classroom.CourseId != null)
                    {
                        Course course = await _searchEntities.FindEntityByIdAsync<Course>(classroom.CourseId);
                        classroom.Course = course;
                    }
                }
            }
        }

        public async Task FillClassroomInStudentsAsync(IEnumerable<Student> students)
        {
            if (students != null)
            {
                foreach (Student student in students)
                {
                    student.Classroom = await _searchEntities.FindEntityByIdAsync<Classroom>(student.ClassroomId);
                }
            }
        }

        public async Task FillClassroomsWithCourseAsync(IEnumerable<Classroom> classrooms)
        {
            if (classrooms != null)
            {
                foreach (Classroom classroom in classrooms)
                {
                    Course course = await _searchEntities.FindEntityByIdAsync<Course>(classroom.CourseId);
                    classroom.Course = course;
                }
            }
        }

        public void FillClassroomWithCourse(Classroom classroom, Course course)
        {
            if (classroom == null || course == null)
            {
                throw new FillException("Problems filling classroom and course objects");
            }

            classroom.CourseId = course.Id;
            classroom.Course = course;
        }

        public void FillStudentWithClassroom(Student student, Classroom classroom)
        {
            if (student == null || classroom == null)
            {
                throw new FillException("Problems filling student and classroom objects");
            }
            student.Classroom = classroom;
        }

        public async Task FillUsersWithClassAsync(IEnumerable<User> users) 
        {
            if(users == null) 
            {
                throw new FillException("Problems filling users objects!");
            }

            foreach(User user in users) 
            {
                user.Class = await _searchEntities.FindClassByIdAsync(user.ClassId);
            }
        }
    }
}

