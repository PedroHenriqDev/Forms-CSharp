using Business.Extensions;
using Datas;
using Entities;
using Entities.TransientClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.BusinessLogic
{
    public class DeleteEntitiesBusiness<T>
    {
        private readonly ConnectionDb ConnectionDb = new ConnectionDb();
        private readonly ValidationEntitiesBusiness<T> ValidationEntities = new ValidationEntitiesBusiness<T>();

        public async Task<StudentQuery> DeleteStudentAsync(Student student) 
        {
            Student studentDb = await ConnectionDb.ReturnStudentByIdAsync(student.StudentId);
            if (studentDb == null || !ValidationEntities.EntityHasId(studentDb.StudentId))
            {
                return new StudentQuery(false, "An error occurred when recognizing the student " + student.CompleteName.CutCompleteName(), DateTime.Now, student);
            }
            await ConnectionDb.DeleteStudentByIdAsync(student.StudentId);
            return new StudentQuery(true, "Student " + student.CompleteName.CutCompleteName() + " deleted successfully", DateTime.Now, student);
        }

        public async Task<CourseQuery> DeleteCourseAsync(Course course) 
        {
            if(course == null || !ValidationEntities.EntityHasId(course.CourseId)) 
            {
                return new CourseQuery(false, "An error occurred when recognizing the course " + course.CourseName, DateTime.Now, course);
            }

            IEnumerable<Classroom> classrooms = await ConnectionDb.ReturnAllClassromsAsync(); 
            DeleteClassroomsAsync(classrooms.Where(c => c.CourseId == course.CourseId).ToList());
            await ConnectionDb.DeleteCourseByIdAsync(course.CourseId);
            return new CourseQuery(true, "Course " + course.CourseName + " deleted successfully", DateTime.Now, course);
        }

        private async Task DeleteClassroomsAsync(IEnumerable<Classroom> classrooms) 
        {
            if(classrooms == null) 
            {
                throw new ArgumentNullException("An error occurred when deleting classrooms, null reference");
            }

            await ConnectionDb.DeleteClassroomInSetAsync(classrooms.Select(x => x.ClassroomId).ToList());
        }
    }
}
