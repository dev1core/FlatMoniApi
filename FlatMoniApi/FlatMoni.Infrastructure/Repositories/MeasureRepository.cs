using FlatMoniApi.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace FlatMoniApi.FlatMoni.Infrastructure.Repositories
{
    class MeasureRepository : IMeasureRepository
    {
        private static ISet<Measure> _measurements = new HashSet<Measure>();

        public void Add(Measure measure)
        {
            _measurements.Add(measure);
        }

        public Measure Get(Guid Id)
        {
            throw new NotImplementedException();
        }

        public Measure Get(DateTime date)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Measure> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Remove(Measure measure)
        {
            throw new NotImplementedException();
        }

        public void Update(Measure measure)
        {
            throw new NotImplementedException();
        }
    }
}
