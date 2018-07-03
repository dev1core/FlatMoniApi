using FlatMoniApi.FlatMoni.Infrastructure.DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FlatMoniApi.FlatMoni.Infrastructure.Services
{
    public interface IMeasureService
    {
        Task<MeasureDto> GetAsync(string name);
        Task RecordAsync(string name, float value, string unit, DateTime date);
    }
}
