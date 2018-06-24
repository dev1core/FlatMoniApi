using FlatMoniApi.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FlatMoniApi.FlatMoni.Infrastructure.Repositories
{
    class MeasureRepository : IMeasureRepository
    {
        private static ISet<Measure> _measurements = new HashSet<Measure>
        {
            new Measure("Temperatura pokoju",24,"Celcius",DateTime.Now),
            new Measure("Temperatura pokoju",23,"Celcius",DateTime.Now),
            new Measure("Temperatura pokoju",22,"Celcius",DateTime.Now)
        };

        public void Add(Measure measure)
        {
            _measurements.Add(measure);
        }

        public Measure Get(Guid Id)
        {
            return _measurements.Single(x => x.Id == Id);
        }

        public Measure Get(DateTime date)
        {
            return _measurements.Single(x => x.Date == date);
        }

        public IEnumerable<Measure> GetAll()
        {
            return _measurements;
        }

        public void Remove(Guid id)
        {
            var user = Get(id);
            _measurements.Remove(user);
        }

        public void Update(Measure measure)
        {
            throw new NotImplementedException();
        }
    }
}
