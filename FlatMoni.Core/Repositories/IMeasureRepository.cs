using FlatMoni.Core.Domain;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FlatMoni.Core.Repositories
{
    public interface IMeasureRepository
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
