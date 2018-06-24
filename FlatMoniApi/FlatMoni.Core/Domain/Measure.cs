using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlatMoniApi
{
    public class Measure
    {
        public Guid Id { get; protected set; }
        public string Name { get; protected set; }
        public float Value { get; protected set; }
        public string Unit { get; protected set; }
        public DateTime Date { get; protected set; }

        protected Measure()
        {
        }

        public Measure(string name, float value, string unit, DateTime date)
        {
            Id = Guid.NewGuid();
            Name = name;
            Value = value;
            Unit = unit;
            Date = date;
        }

        //dodanie walidacji
    }
}
