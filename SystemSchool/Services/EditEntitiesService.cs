using Business.Extensions;
using Datas;
using Entities;
using Entities.TransientClasses;
using System;
using System.Threading.Tasks;

namespace Services
{
    public class EditEntitiesService<T>
    {
        private readonly ConnectionDb _connectionDb;
        private readonly EncryptEntitiesService _encryptEntitiesService;
        private readonly ValidationEntitiesService _validationEntities;

        public EditEntitiesService(
            ConnectionDb connectionDb,
            ValidationEntitiesService validationEntities,
           EncryptEntitiesService encryptEntitiesService )
        {
            _connectionDb = connectionDb;
            _validationEntities = validationEntities;
            _encryptEntitiesService = encryptEntitiesService;
        }

        public async Task<EntityQuery<Student>> EditStudentAsync(Student student)
        {
            if (_validationEntities.IsValidStudent(student))
            {
                await _connectionDb.EditStudentInDbAsync(student);
                return new EntityQuery<Student>(true, "Student " + student.CompleteName.CutCompleteName() + " edited successfully", DateTime.Now, student);
            }
            return new EntityQuery<Student>(false, "Student " + student.CompleteName.CutCompleteName() + " to be edited there must be some change", DateTime.Now, student);
        }

        public async Task<EntityQuery<Classroom>> EditClassroomAsync(Classroom classroom)
        {
            if (_validationEntities.ClassroomNameIsInCorrectOrder(classroom.ClassroomName) && _validationEntities.EntityHasId(classroom.Id))
            {
                await _connectionDb.EditClassroomInDbAsync(classroom);
                return new EntityQuery<Classroom>(true, "Classroom " + classroom.ClassroomName.CutCompleteName() + " edited successfully", DateTime.Now, classroom);
            }
            return new EntityQuery<Classroom>(false, "Classroom " + classroom.ClassroomName.CutCompleteName() + " to be edited there must be some change", DateTime.Now, classroom);
        }

        public async Task<EntityQuery<User>> EditPasswordAsync(User user)
        {
            if (!string.IsNullOrWhiteSpace(user.PasswordHash))
            {
                user.PasswordHash = _encryptEntitiesService.EncryptPasswordSHA512(user.PasswordHash);
                await _connectionDb.EditPasswordInDbAsync(user);
                return new EntityQuery<User>(true, "User " + user.Username.CutCompleteName() + " edited successfully", DateTime.Now, user);
            }
            return new EntityQuery<User>(false, "User " + user.Username.CutCompleteName() + " password cannot be empty", DateTime.Now, user);
        }

        public async Task<EntityQuery<User>> EditUserAsync(User user)
        {
            if (_validationEntities.EntityHasId(user.Id) && _validationEntities.EntityHasId(user.GroupId) && !string.IsNullOrWhiteSpace(user.Username))
            {
                await _connectionDb.EditUserInDbAsync(user);
                return new EntityQuery<User>(true, "User " + user.Username.CutCompleteName() + " edit successfully", DateTime.Now, user);
            }
            return new EntityQuery<User>(false, "User " + user.Username.CutCompleteName() + " Username cannot be empty", DateTime.Now, user);
        }
    }
}
