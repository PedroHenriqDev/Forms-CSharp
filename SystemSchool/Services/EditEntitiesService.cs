using Business.Extensions;
using Datas;
using Entities;
using Entities.TransientClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class EditEntitiesService<T>
    {
        private readonly ConnectionDb _connectionDb;
        private readonly SearchEntitiesService _searchEntities;
        private readonly ValidationEntitiesService<T> _validationEntities;

        public EditEntitiesService(
            ConnectionDb connectionDb, 
            ValidationEntitiesService<T> validationEntities,
            SearchEntitiesService searchEntities)
        {
            _connectionDb = connectionDb;
            _validationEntities = validationEntities;
            _searchEntities = searchEntities;
        }

        public async Task<EntityQuery<Student>> EditStudentAsync(Student student)
        {
            if(_validationEntities.IsValidStudent(student)) 
            {
                await _connectionDb.EditStudentInDbAsync(student);
                return new EntityQuery<Student>(true,"Student " + student.CompleteName.CutCompleteName() + " edited successfully", DateTime.Now, student);
            }
            return new EntityQuery<Student>(false, "Student " + student.CompleteName.CutCompleteName() + " to be edited there must be some change", DateTime.Now, student);
        }

        public async Task<EntityQuery<Classroom>> EditClassroomAsync(Classroom classroom) 
        {
            if(_validationEntities.ClassroomNameIsInCorrectOrder(classroom.ClassroomName) && _validationEntities.EntityHasId(classroom.Id)) 
            {
                await _connectionDb.EditClassroomInDbAsync(classroom);
                return new EntityQuery<Classroom>(true,"Classroom " + classroom.ClassroomName.CutCompleteName() + " edited successfully", DateTime.Now, classroom);
            }
            return new EntityQuery<Classroom>(false, "Classroom " + classroom.ClassroomName.CutCompleteName() + " to be edited there must be some change", DateTime.Now, classroom);
        }
    }
}
