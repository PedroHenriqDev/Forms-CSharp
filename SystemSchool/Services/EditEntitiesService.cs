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
        private readonly ValidationEntitiesService<T> _validationEntities;

        public EditEntitiesService(ConnectionDb connectionDb, ValidationEntitiesService<T> validationEntities)
        {
            _connectionDb = connectionDb;
            _validationEntities = validationEntities;
        }

        public async Task<StudentQuery> EditStudentAsync(Student student)
        {
            if(_validationEntities.IsValidStudent(student)) 
            {
                await _connectionDb.EditStudentInDbAsync(student);
                return new StudentQuery(true,"Student " + student.CompleteName.CutCompleteName() + " edited successfully", DateTime.Now, student);
            }
            return new StudentQuery(false, "Student " + student.CompleteName.CutCompleteName() + " to be edited there must be some change", DateTime.Now, student);
        }
    }
}
