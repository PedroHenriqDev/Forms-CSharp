using Datas;
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
    }
}
