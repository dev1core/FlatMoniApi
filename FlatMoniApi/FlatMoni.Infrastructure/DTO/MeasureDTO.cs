using System;
using System.Collections.Generic;
using System.Text;

namespace FlatMoniApi.FlatMoni.Infrastructure.DTO
{
    public class MeasureDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public float Value { get; set; }
        public string Unit { get; set; }
        public DateTime Date { get; set; }
    }
}
