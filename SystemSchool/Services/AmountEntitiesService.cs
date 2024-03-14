using Datas;
using Entities;
using Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class AmountEntitiesService
    {
        private readonly SearchEntitiesService _searchEntitiesService;

        public AmountEntitiesService(SearchEntitiesService searchEntitiesService)
        {
            _searchEntitiesService = searchEntitiesService;
        }

        public async Task<int> AmountEntitiesByDateCreationAsync<T>(int start, int end) where T : class, IEntity<T>
        {
            IEnumerable<T> entities = await _searchEntitiesService.FindAllEntitiesAsync<T>();

            return entities.Count(e => e.DateCreation.Month >= start && e.DateCreation.Month <= end && e.DateCreation.Year == DateTime.Now.Year);
        }

        public async Task<int> TotalAmountEntitiesAsync() 
        {
            return await AmountEntitiesByDateCreationAsync<Classroom>(1, 12) +
                  await AmountEntitiesByDateCreationAsync<User>(1, 12) +
                  await AmountEntitiesByDateCreationAsync<Student>(1, 12) +
                  await AmountEntitiesByDateCreationAsync<Course>(1, 12);
        }

        public async Task<double> CalculatePencentageAsync(int amount) 
        {
            int totalAmount = await TotalAmountEntitiesAsync();

            int classroomAmount = await AmountEntitiesByDateCreationAsync<Classroom>(1, 12);
            int userAmount = await AmountEntitiesByDateCreationAsync<User>(1, 12);
            int studentAmount = await AmountEntitiesByDateCreationAsync<User>(1, 12);
            int courseAmount = await AmountEntitiesByDateCreationAsync<User>(1, 12);

            return (double)amount / totalAmount * 100;
        }
    }
}
