using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlatMoniApi
{
    public class MeasureModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }
        public string Unit { get; set; }
        public DateTime Date { get; set; }
    }
}
