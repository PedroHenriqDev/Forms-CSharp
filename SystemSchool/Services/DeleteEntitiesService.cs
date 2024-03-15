using Business.Extensions;
using Datas;
using Entities;
using Entities.Interfaces;
using Entities.TransientClasses;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class DeleteEntitiesService<T>
    {
        private readonly ConnectionDb _connectionDb;
        private readonly ValidationEntitiesService _validationEntities;
        private readonly SearchEntitiesService _searchService;

        public DeleteEntitiesService(ConnectionDb connectionDb, ValidationEntitiesService validationEntities, SearchEntitiesService searchService)
        {
            _connectionDb = connectionDb;
            _validationEntities = validationEntities;
            _searchService = searchService;
        }

        public async Task<EntityQuery<T>> DeleteEntityAsync<T>(T entity) where T : class, IEntity<T>
        {
            string nameEntity = typeof(T).Name;
            if (entity == null || !_validationEntities.EntityHasId(entity.Id))
            {
                return new EntityQuery<T>(false, $"An error ocurred when recognizing the {nameEntity}", DateTime.Now, entity);
            }

            await _connectionDb.DeleteRecordInTableByIdAsync<T>(entity.Id);
            return new EntityQuery<T>(true, $"{nameEntity} delete successfully!", DateTime.Now, entity);
        }

        public async Task DeleteEntitiesAsync<T>(IEnumerable<T> entities) where T : class, IEntity<T>
        {
            if (entities.Any())
            {
                await _connectionDb.DeleteRecordsInTableByIdAsync<T>(entities
                    .Select(c => c.Id)
                    .ToList());
            }
        }

        public async Task DeleteStudentsInClassroomsAsync(IEnumerable<Classroom> classrooms) 
        {
            if(classrooms == null) 
            {
                return;
            }

            foreach(Classroom classroom in classrooms) 
            {
                IEnumerable<Student> students = await _searchService.FindEntitiesByReferenceIdAsync<Student, Classroom>(classroom);
                await _connectionDb.DeleteRecordsInTableByIdAsync<Student>(students.Select(s => s.Id).ToList());
            }
        }

        public async Task DeleteClassromsByCourseIdAsync(IEnumerable<Classroom> classrooms, int courseId) 
        {
            if (classrooms.Any()) 
            {
                await _connectionDb.DeleteRecordsInTableByIdAsync<Classroom>(classrooms
               .Where(c => c.CourseId == courseId)
               .Select(c => c.Id)
               .ToList());
            }
        }
    }
}
