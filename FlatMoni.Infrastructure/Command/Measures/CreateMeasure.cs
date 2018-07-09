using System;
using System.Collections.Generic;
using System.Text;

namespace FlatMoniApi.FlatMoni.Infrastructure.Command.Users
{
    public class CreateMeasure : ICommand
    {
        public string Name { get; set; }
        public float Value { get; set; }
        public string Unit { get; set; }
        public DateTime Date { get; set; }
    }
}
