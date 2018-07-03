using FlatMoniApi.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlatMoniApi.FlatMoni.Infrastructure.Repositories
{
    class MeasureRepository : IMeasureRepository
    {
        private static ISet<Measure> _measurements = new HashSet<Measure>
        {
            new Measure("temp1",24,"Celcius", DateTime.Parse("5/1/2008 8:30:52 AM",
                                      System.Globalization.CultureInfo.InvariantCulture)),
            new Measure("temp2",23,"Celcius", DateTime.Parse("6/1/2008 8:30:52 AM",
                                      System.Globalization.CultureInfo.InvariantCulture)),
            new Measure("temp3",22,"Celcius", DateTime.Parse("7/1/2008 8:30:52 AM",
                                      System.Globalization.CultureInfo.InvariantCulture))
        };

        public async Task AddAsync(Measure measure)
        {
            _measurements.Add(measure);
            await Task.CompletedTask;
        }

        public async Task<Measure> GetAsync(Guid Id) => await Task.FromResult(_measurements.SingleOrDefault(x => x.Id == Id));

        public async Task<Measure> GetAsync(string name) => await Task.FromResult(_measurements.SingleOrDefault(x => x.Name == name));

        public async Task<IEnumerable<Measure>> GetAllAsync() => await Task.FromResult(_measurements);

        public async Task RemoveAsync(Guid id)
        {
            var user = await GetAsync(id);
            _measurements.Remove(user);
            await Task.CompletedTask;
        }

        public async Task UpdateAsync(Measure measure)
        {
            await Task.CompletedTask;
        }
    }
}
