using Entities;
using Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Services
{
    /// <summary>
    /// Provides methods for calculating the amount of entities.
    /// </summary>
    public class AmountEntitiesService
    {
        private readonly SearchEntitiesService _searchEntitiesService;

        /// <summary>
        /// Initializes a new instance of the <see cref="AmountEntitiesService"/> class.
        /// </summary>
        /// <param name="searchEntitiesService">The search service.</param>
        public AmountEntitiesService(SearchEntitiesService searchEntitiesService)
        {
            _searchEntitiesService = searchEntitiesService ?? throw new ArgumentNullException(nameof(searchEntitiesService));
        }

        /// <summary>
        /// Calculates the amount of entities created within a specified date range.
        /// </summary>
        /// <typeparam name="T">The type of entity.</typeparam>
        /// <param name="start">The starting month of the date range.</param>
        /// <param name="end">The ending month of the date range.</param>
        /// <returns>The number of entities created within the specified date range.</returns>
        public async Task<int> AmountEntitiesByDateCreationAsync<T>(int start, int end) where T : class, IEntity<T>
        {
            IEnumerable<T> entities = await _searchEntitiesService.FindAllEntitiesAsync<T>();

            return entities.Count(e => e.DateCreation.Month >= start && e.DateCreation.Month <= end && e.DateCreation.Year == DateTime.Now.Year);
        }

        /// <summary>
        /// Calculates the total amount of entities.
        /// </summary>
        /// <returns>The total number of entities.</returns>
        public async Task<int> TotalAmountEntitiesAsync()
        {
            return await AmountEntitiesByDateCreationAsync<Classroom>(1, 12) +
                  await AmountEntitiesByDateCreationAsync<User>(1, 12) +
                  await AmountEntitiesByDateCreationAsync<Student>(1, 12) +
                  await AmountEntitiesByDateCreationAsync<Course>(1, 12);
        }

        /// <summary>
        /// Calculates the percentage of a given amount in relation to the total amount of entities.
        /// </summary>
        /// <param name="amount">The amount of entities to calculate the percentage for.</param>
        /// <returns>The percentage of the given amount in relation to the total amount of entities.</returns>
        public async Task<double> CalculatePencentageAsync(int amount)
        {
            int totalAmount = await TotalAmountEntitiesAsync();
            return (double)amount / totalAmount * 100;
        }
    }
}
