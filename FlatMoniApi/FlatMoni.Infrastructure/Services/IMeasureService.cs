using FlatMoniApi.FlatMoni.Infrastructure.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace FlatMoniApi.FlatMoni.Infrastructure.Services
{
    public interface IMeasureService
    {
        MeasureDto Get(string name, DateTime date);
        void Record(string name, float value, string unit, DateTime date);
    }
}
