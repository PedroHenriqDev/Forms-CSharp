using Business.Extensions;
using Datas;
using Entities;
using Entities.TransientClasses;
using System;
using System.Threading.Tasks;

namespace Services
{
    public class CreateEntitiesService<T>
    {
        private readonly ConnectionDb _connectionDb;
        private readonly ValidationEntitiesService _validationEntities;
        private readonly SearchEntitiesService _searchEntities;
        private readonly EncryptEntitiesService _encryptEntities;
        
        public CreateEntitiesService(ConnectionDb connectionDb, ValidationEntitiesService validationEntities, SearchEntitiesService searchEntities, EncryptEntitiesService encryptEntities) 
        {
            _connectionDb = connectionDb;
            _validationEntities = validationEntities;
            _searchEntities = searchEntities;
            _encryptEntities = encryptEntities;
        }

        public async Task<EntityQuery<Course>> CreateCourseAsync(Course course)
        {
            if (await _validationEntities.IsValidCourseAsync(course))
            {
                await _connectionDb.CreateCourseInDbAsync(course);
                return new EntityQuery<Course>(true, "Course " + course.CourseName + " created successfully!", DateTime.Now, course);
            }
            return new EntityQuery<Course>(false, course.CourseName + " course already exists", DateTime.Now, course);
        }

        public async Task<EntityQuery<User>> CreateUserAsync(User user) 
        {
            user.PasswordHash = _encryptEntities.EncryptPasswordSHA512(user.PasswordHash);
            if (await _validationEntities.IsValidUserAsync(user))
            {
                await _connectionDb.CreateUserInDbAsync(user);
                return new EntityQuery<User>(true, "User " + user.Username + " created successfully!", DateTime.Now, user);
            }
            return new EntityQuery<User>(false, "User " + user.Username + " user already exists!", DateTime.Now, user);
        }

        public async Task<EntityQuery<Student>> CreateStudentAsync(Student student) 
        {
            if (_validationEntities.IsValidStudent(student)) 
            {
                await _connectionDb.CreateStudentInDbAsync(student);
                return new EntityQuery<Student>(true, "Student " + student.CompleteName.CutCompleteName() + " created successfully!", DateTime.Now, student);
            }
                return new EntityQuery<Student>(false, "Student " + student.CompleteName.CutCompleteName() + " student already exists!", DateTime.Now, student);
        }

        public async Task<EntityQuery<Classroom>> CreateClassroomAsync(Classroom classroom) 
        {
            if (await _validationEntities.IsValidClassroomAsync(classroom))
            {
                await _connectionDb.CreateClassroomInDbAsync(classroom);
                return new EntityQuery<Classroom>(true, "Classroom " + classroom.ClassroomName + " created successfully!", DateTime.Now, classroom);
            }
            return new EntityQuery<Classroom>(false, "Classroom " + classroom.ClassroomName + " classroom already exist!", DateTime.Now, classroom);
        }
    }
}
 