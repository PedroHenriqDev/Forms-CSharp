using Business.Extensions;
using Datas;
using Entities;
using Entities.Interfaces;
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
            Student studentDb = await ConnectionDb.ReturnStudentByIdAsync(student.Id);
            if (studentDb == null || !ValidationEntities.EntityHasId(studentDb.Id))
            {
                return new StudentQuery(false, "An error occurred when recognizing the student " + student.CompleteName.CutCompleteName(), DateTime.Now, student);
            }
            await ConnectionDb.DeleteStudentByIdAsync(student.Id);
            return new StudentQuery(true, "Student " + student.CompleteName.CutCompleteName() + " deleted successfully", DateTime.Now, student);
        }

        public async Task<CourseQuery> DeleteCourseAsync(Course course) 
        {
            if(course == null || !ValidationEntities.EntityHasId(course.Id)) 
            {
                return new CourseQuery(false, "An error occurred when recognizing the course " + course.CourseName, DateTime.Now, course);
            }

            IEnumerable<Classroom> classrooms = await ConnectionDb.ReturnAllClassromsAsync(); 
            await DeleteRecordsByTableAsync(classrooms.Where(c => c.CourseId == course.Id).ToList(), "Courses");
            await ConnectionDb.DeleteCourseByIdAsync(course.Id);
            return new CourseQuery(true, "Course " + course.CourseName + " deleted successfully", DateTime.Now, course);
        }

        public async Task<ClassroomQuery> DeleteClassroomAsync(Classroom classroom) 
        {
            if(classroom == null || !ValidationEntities.EntityHasId(classroom.Id)) 
            {
                return new ClassroomQuery(false, "An error occurred when recognizing the course " + classroom.ClassroomName, DateTime.Now, classroom);
            }
            IEnumerable<Student> students = await ConnectionDb.ReturnAllStudentsAsync();
            await DeleteRecordsByTableAsync(students.Where(c => c.ClassroomId == classroom.Id).ToList(), "Classrooms");
            return new ClassroomQuery(true, "Classroom " + classroom.ClassroomName + " deleted successfully", DateTime.Now, classroom);

        }

        private async Task DeleteRecordsByTableAsync(IEnumerable<IEntity> entities, string table) 
        {
            await ConnectionDb.DeleteRecordsInTableAsync(entities.Select(x => x.Id).ToList(), table);
        }
    }
}
