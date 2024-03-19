using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Services.Exceptions;

namespace Services
{
    /// <summary>
    /// Provides methods for filling entities with related data.
    /// </summary>
    public class FillEntitiesService
    {
        private readonly SearchEntitiesService _searchEntities;

        /// <summary>
        /// Initializes a new instance of the <see cref="FillEntitiesService"/> class.
        /// </summary>
        /// <param name="searchEntities">The service for searching entities.</param>
        public FillEntitiesService(SearchEntitiesService searchEntities)
        {
            _searchEntities = searchEntities ?? throw new ArgumentNullException(nameof(searchEntities));
        }

        /// <summary>
        /// Fills the course in each classroom asynchronously.
        /// </summary>
        /// <param name="classrooms">The collection of classrooms.</param>
        /// <returns>A task representing the asynchronous operation.</returns>
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

        /// <summary>
        /// Fills the classroom in each student asynchronously.
        /// </summary>
        /// <param name="students">The collection of students.</param>
        /// <returns>A task representing the asynchronous operation.</returns>
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

        /// <summary>
        /// Fills each classroom with its associated course asynchronously.
        /// </summary>
        /// <param name="classrooms">The collection of classrooms.</param>
        /// <returns>A task representing the asynchronous operation.</returns>
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

        /// <summary>
        /// Fills the classroom with the specified course.
        /// </summary>
        /// <param name="classroom">The classroom to fill.</param>
        /// <param name="course">The course to associate with the classroom.</param>
        public void FillClassroomWithCourse(Classroom classroom, Course course)
        {
            if (classroom == null || course == null)
            {
                throw new FillException("Problems filling classroom and course objects");
            }

            classroom.CourseId = course.Id;
            classroom.Course = course;
        }

        /// <summary>
        /// Fills the student with the specified classroom.
        /// </summary>
        /// <param name="student">The student to fill.</param>
        /// <param name="classroom">The classroom to associate with the student.</param>
        public void FillStudentWithClassroom(Student student, Classroom classroom)
        {
            if (student == null || classroom == null)
            {
                throw new FillException("Problems filling student and classroom objects");
            }
            student.Classroom = classroom;
        }

        /// <summary>
        /// Fills the user with its associated group asynchronously.
        /// </summary>
        /// <param name="user">The user to fill.</param>
        /// <returns>A task representing the asynchronous operation.</returns>
        public async Task FillUserWithGroupAsync(User user)
        {
            if (user == null)
            {
                throw new FillException("Problems filling users objects!");
            }

            user.Group = await _searchEntities.FindEntityByIdAsync<Group>(user.GroupId);
        }

        /// <summary>
        /// Fills each user with its associated group asynchronously.
        /// </summary>
        /// <param name="users">The collection of users.</param>
        /// <returns>A task representing the asynchronous operation.</returns>
        public async Task FillUsersWithGroupAsync(IEnumerable<User> users)
        {
            if (users == null)
            {
                throw new FillException("Problems filling users objects!");
            }

            foreach (User user in users)
            {
                user.Group = await _searchEntities.FindEntityByIdAsync<Group>(user.GroupId);
            }
        }
    }
}
