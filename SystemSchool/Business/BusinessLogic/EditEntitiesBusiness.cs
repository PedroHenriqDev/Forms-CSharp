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

namespace Business.BusinessLogic
{
    public class EditEntitiesBusiness<T>
    {
        private readonly ConnectionDb ConnectionDb = new ConnectionDb();
        private readonly ValidationEntitiesBusiness<T> ValidationEntities = new ValidationEntitiesBusiness<T>();

        public async Task<StudentQuery> EditStudentAsync(Student student)
        {
            if(ValidationEntities.IsValidStudent(student)) 
            {
                await ConnectionDb.EditStudentInDbAsync(student);
                return new StudentQuery(true,"Student " + student.CompleteName.CutCompleteName() + " edited successfully", DateTime.Now, student);
            }
            return new StudentQuery(false, "Student " + student.CompleteName.CutCompleteName() + " to be edited there must be some change", DateTime.Now, student);
        }
    }
}
