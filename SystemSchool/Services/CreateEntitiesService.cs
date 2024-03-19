using Business.Extensions;
using Datas;
using Entities;
using Entities.TransientClasses;
using System;
using System.Threading.Tasks;

namespace Services
{
    /// <summary>
    /// Provides methods for creating entities.
    /// </summary>
    /// <typeparam name="T">The type of entity to create.</typeparam>
    public class CreateEntitiesService<T>
    {
        private readonly ConnectionDb _connectionDb;
        private readonly ValidationEntitiesService _validationEntities;
        private readonly SearchEntitiesService _searchEntities;
        private readonly EncryptEntitiesService _encryptEntities;

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateEntitiesService{T}"/> class.
        /// </summary>
        /// <param name="connectionDb">The database connection.</param>
        /// <param name="validationEntities">The validation service.</param>
        /// <param name="searchEntities">The search service.</param>
        /// <param name="encryptEntities">The encryption service.</param>
        public CreateEntitiesService(ConnectionDb connectionDb, ValidationEntitiesService validationEntities, SearchEntitiesService searchEntities, EncryptEntitiesService encryptEntities)
        {
            _connectionDb = connectionDb ?? throw new ArgumentNullException(nameof(connectionDb));
            _validationEntities = validationEntities ?? throw new ArgumentNullException(nameof(validationEntities));
            _searchEntities = searchEntities ?? throw new ArgumentNullException(nameof(searchEntities));
            _encryptEntities = encryptEntities ?? throw new ArgumentNullException(nameof(encryptEntities));
        }

        /// <summary>
        /// Creates a course asynchronously.
        /// </summary>
        /// <param name="course">The course to create.</param>
        /// <returns>An <see cref="EntityQuery{T}"/> containing the result of the operation.</returns>
        public async Task<EntityQuery<Course>> CreateCourseAsync(Course course)
        {
            if (await _validationEntities.IsValidCourseAsync(course))
            {
                await _connectionDb.CreateCourseInDbAsync(course);
                return new EntityQuery<Course>(true, "Course " + course.CourseName + " created successfully!", DateTime.Now, course);
            }
            return new EntityQuery<Course>(false, course.CourseName + " course already exists", DateTime.Now, course);
        }

        /// <summary>
        /// Creates a user asynchronously.
        /// </summary>
        /// <param name="user">The user to create.</param>
        /// <returns>An <see cref="EntityQuery{T}"/> containing the result of the operation.</returns>
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

        /// <summary>
        /// Creates a student asynchronously.
        /// </summary>
        /// <param name="student">The student to create.</param>
        /// <returns>An <see cref="EntityQuery{T}"/> containing the result of the operation.</returns>
        public async Task<EntityQuery<Student>> CreateStudentAsync(Student student)
        {
            if (_validationEntities.IsValidStudent(student))
            {
                await _connectionDb.CreateStudentInDbAsync(student);
                return new EntityQuery<Student>(true, "Student " + student.CompleteName.CutCompleteName() + " created successfully!", DateTime.Now, student);
            }
            return new EntityQuery<Student>(false, "Student " + student.CompleteName.CutCompleteName() + " student already exists!", DateTime.Now, student);
        }

        /// <summary>
        /// Creates a classroom asynchronously.
        /// </summary>
        /// <param name="classroom">The classroom to create.</param>
        /// <returns>An <see cref="EntityQuery{T}"/> containing the result of the operation.</returns>
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
