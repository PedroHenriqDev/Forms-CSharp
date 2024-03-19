using Datas;
using Entities;
using Entities.Interfaces;
using Entities.TransientClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Services
{
    /// <summary>
    /// Provides methods for deleting entities.
    /// </summary>
    /// <typeparam name="T">The type of entity to delete.</typeparam>
    public class DeleteEntitiesService<T>
    {
        private readonly ConnectionDb _connectionDb;
        private readonly ValidationEntitiesService _validationEntities;
        private readonly SearchEntitiesService _searchService;

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteEntitiesService{T}"/> class.
        /// </summary>
        /// <param name="connectionDb">The database connection.</param>
        /// <param name="validationEntities">The validation service.</param>
        /// <param name="searchService">The search service.</param>
        public DeleteEntitiesService(ConnectionDb connectionDb, ValidationEntitiesService validationEntities, SearchEntitiesService searchService)
        {
            _connectionDb = connectionDb ?? throw new ArgumentNullException(nameof(connectionDb));
            _validationEntities = validationEntities ?? throw new ArgumentNullException(nameof(validationEntities));
            _searchService = searchService ?? throw new ArgumentNullException(nameof(searchService));
        }

        /// <summary>
        /// Deletes a single entity asynchronously.
        /// </summary>
        /// <param name="entity">The entity to delete.</param>
        /// <returns>An <see cref="EntityQuery{T}"/> containing the result of the operation.</returns>
        public async Task<EntityQuery<T>> DeleteEntityAsync<T>(T entity) where T : class, IEntity<T>
        {
            string nameEntity = typeof(T).Name;
            if (entity == null || !_validationEntities.EntityHasId(entity.Id))
            {
                return new EntityQuery<T>(false, $"An error occurred when recognizing the {nameEntity}", DateTime.Now, entity);
            }

            await _connectionDb.DeleteRecordInTableByIdAsync<T>(entity.Id);
            return new EntityQuery<T>(true, $"{nameEntity} deleted successfully!", DateTime.Now, entity);
        }

        /// <summary>
        /// Deletes multiple entities asynchronously.
        /// </summary>
        /// <param name="entities">The collection of entities to delete.</param>
        /// <returns>A task representing the asynchronous operation.</returns>
        public async Task DeleteEntitiesAsync<T>(IEnumerable<T> entities) where T : class, IEntity<T>
        {
            if (entities.Any())
            {
                await _connectionDb.DeleteRecordsInTableByIdAsync<T>(entities
                    .Select(c => c.Id)
                    .ToList());
            }
        }

        /// <summary>
        /// Deletes students associated with the provided classrooms asynchronously.
        /// </summary>
        /// <param name="classrooms">The classrooms whose students are to be deleted.</param>
        /// <returns>A task representing the asynchronous operation.</returns>
        public async Task DeleteStudentsInClassroomsAsync(IEnumerable<Classroom> classrooms)
        {
            if (classrooms == null)
            {
                return;
            }

            foreach (Classroom classroom in classrooms)
            {
                IEnumerable<Student> students = await _searchService.FindEntitiesByReferenceIdAsync<Student, Classroom>(classroom);
                await _connectionDb.DeleteRecordsInTableByIdAsync<Student>(students.Select(s => s.Id).ToList());
            }
        }

        /// <summary>
        /// Deletes classrooms associated with the provided course ID asynchronously.
        /// </summary>
        /// <param name="classrooms">The classrooms to delete.</param>
        /// <param name="courseId">The ID of the course associated with the classrooms.</param>
        /// <returns>A task representing the asynchronous operation.</returns>
        public async Task DeleteClassroomsByCourseIdAsync(IEnumerable<Classroom> classrooms, int courseId)
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
