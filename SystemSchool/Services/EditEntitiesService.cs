using Business.Extensions;
using Datas;
using Entities;
using Entities.TransientClasses;
using System;
using System.Threading.Tasks;

namespace Services
{
    /// <summary>
    /// Provides methods for editing entities.
    /// </summary>
    /// <typeparam name="T">The type of entity to edit.</typeparam>
    public class EditEntitiesService<T>
    {
        private readonly ConnectionDb _connectionDb;
        private readonly EncryptEntitiesService _encryptEntitiesService;
        private readonly ValidationEntitiesService _validationEntities;

        /// <summary>
        /// Initializes a new instance of the <see cref="EditEntitiesService{T}"/> class.
        /// </summary>
        /// <param name="connectionDb">The database connection.</param>
        /// <param name="validationEntities">The validation service.</param>
        /// <param name="encryptEntitiesService">The encryption service.</param>
        public EditEntitiesService(
            ConnectionDb connectionDb,
            ValidationEntitiesService validationEntities,
            EncryptEntitiesService encryptEntitiesService)
        {
            _connectionDb = connectionDb ?? throw new ArgumentNullException(nameof(connectionDb));
            _validationEntities = validationEntities ?? throw new ArgumentNullException(nameof(validationEntities));
            _encryptEntitiesService = encryptEntitiesService ?? throw new ArgumentNullException(nameof(encryptEntitiesService));
        }

        /// <summary>
        /// Edits a student entity asynchronously.
        /// </summary>
        /// <param name="student">The student entity to edit.</param>
        /// <returns>An <see cref="EntityQuery{T}"/> containing the result of the operation.</returns>
        public async Task<EntityQuery<Student>> EditStudentAsync(Student student)
        {
            if (_validationEntities.IsValidStudent(student))
            {
                await _connectionDb.EditStudentInDbAsync(student);
                return new EntityQuery<Student>(true, "Student " + student.CompleteName.CutCompleteName() + " edited successfully", DateTime.Now, student);
            }
            return new EntityQuery<Student>(false, "Student " + student.CompleteName.CutCompleteName() + " must have some changes to be edited", DateTime.Now, student);
        }

        /// <summary>
        /// Edits a classroom entity asynchronously.
        /// </summary>
        /// <param name="classroom">The classroom entity to edit.</param>
        /// <returns>An <see cref="EntityQuery{T}"/> containing the result of the operation.</returns>
        public async Task<EntityQuery<Classroom>> EditClassroomAsync(Classroom classroom)
        {
            if (_validationEntities.ClassroomNameIsInCorrectOrder(classroom.ClassroomName) && _validationEntities.EntityHasId(classroom.Id))
            {
                await _connectionDb.EditClassroomInDbAsync(classroom);
                return new EntityQuery<Classroom>(true, "Classroom " + classroom.ClassroomName.CutCompleteName() + " edited successfully", DateTime.Now, classroom);
            }
            return new EntityQuery<Classroom>(false, "Classroom " + classroom.ClassroomName.CutCompleteName() + " must have some changes to be edited", DateTime.Now, classroom);
        }

        /// <summary>
        /// Edits a user's password asynchronously.
        /// </summary>
        /// <param name="user">The user entity containing the new password.</param>
        /// <returns>An <see cref="EntityQuery{T}"/> containing the result of the operation.</returns>
        public async Task<EntityQuery<User>> EditPasswordAsync(User user)
        {
            if (!string.IsNullOrWhiteSpace(user.PasswordHash))
            {
                user.PasswordHash = _encryptEntitiesService.EncryptPasswordSHA512(user.PasswordHash);
                await _connectionDb.EditPasswordInDbAsync(user);
                return new EntityQuery<User>(true, "User " + user.Username.CutCompleteName() + " password edited successfully", DateTime.Now, user);
            }
            return new EntityQuery<User>(false, "User " + user.Username.CutCompleteName() + " password cannot be empty", DateTime.Now, user);
        }

        /// <summary>
        /// Edits a user entity asynchronously.
        /// </summary>
        /// <param name="user">The user entity to edit.</param>
        /// <returns>An <see cref="EntityQuery{T}"/> containing the result of the operation.</returns>
        public async Task<EntityQuery<User>> EditUserAsync(User user)
        {
            if (_validationEntities.EntityHasId(user.Id) && _validationEntities.EntityHasId(user.GroupId) && !string.IsNullOrWhiteSpace(user.Username))
            {
                await _connectionDb.EditUserInDbAsync(user);
                return new EntityQuery<User>(true, "User " + user.Username.CutCompleteName() + " edited successfully", DateTime.Now, user);
            }
            return new EntityQuery<User>(false, "User " + user.Username.CutCompleteName() + " must have some changes to be edited", DateTime.Now, user);
        }
    }
}
