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
            new Measure("temp1",24,"Celcius", DateTime.Parse("5/1/2008 8:30:52 AM",
                                      System.Globalization.CultureInfo.InvariantCulture)),
            new Measure("temp2",23,"Celcius", DateTime.Parse("6/1/2008 8:30:52 AM",
                                      System.Globalization.CultureInfo.InvariantCulture)),
            new Measure("temp3",22,"Celcius", DateTime.Parse("7/1/2008 8:30:52 AM",
                                      System.Globalization.CultureInfo.InvariantCulture))
        };

        public void Add(Measure measure)
        {
            _measurements.Add(measure);
        }

        public Measure Get(Guid Id)
        {
            return _measurements.Single(x => x.Id == Id);
        }

        public Measure Get(string name)
        {
            return _measurements.Single(x => x.Name == name);
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
