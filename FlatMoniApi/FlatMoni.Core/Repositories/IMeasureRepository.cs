using System;
using System.Collections.Generic;
using System.Text;

namespace FlatMoniApi.Repositories
{
    interface IMeasure
    {
        //cqs pattern

        Measure Get(Guid Id);

        Measure Get(DateTime date);

        IEnumerable<Measure> GetAll();

        void Add(Measure measure);

        void Update(Measure measure);

        void Remove(Measure measure);

    }
}
