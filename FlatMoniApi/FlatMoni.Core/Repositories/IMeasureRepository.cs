using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FlatMoniApi.Repositories
{
    interface IMeasureRepository
    {
        //cqs pattern

        Task <Measure> GetAsync(Guid Id);

        Task <Measure> GetAsync(string name);

        Task <IEnumerable<Measure>> GetAllAsync();

        Task AddAsync(Measure measure);

        Task UpdateAsync(Measure measure);

        Task RemoveAsync(Guid id);
    }
}
