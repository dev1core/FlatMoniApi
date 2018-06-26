using System;
using System.Collections.Generic;
using System.Text;

namespace FlatMoniApi.Repositories
{
    interface IMeasureRepository
    {
        //cqs pattern

        Measure Get(Guid Id);

        Measure Get(string name);

        IEnumerable<Measure> GetAll();

        void Add(Measure measure);

        void Update(Measure measure);

        void Remove(Guid id);
    }
}
