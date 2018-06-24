using FlatMoniApi.FlatMoni.Infrastructure.DTO;
using FlatMoniApi.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace FlatMoniApi.FlatMoni.Infrastructure.Services
{
    class MeasureService : IMeasureService
    {
        private readonly IMeasureRepository _measureRepository;

        public MeasureService(IMeasureRepository measureRepository)
        {
            _measureRepository = measureRepository;

        }

        public MeasureDto Get(DateTime date)
        {
            var measure = _measureRepository.Get(date);
            return new MeasureDto {
                Id = measure.Id,
                Date = measure.Date,
                Name = measure.Name,
                Unit = measure.Unit,
                Value = measure.Value
            };
        }

        public void Record(string name, float value, string unit)
        {
            var measure = new Measure(name, value, unit);

            _measureRepository.Add(measure);
        }
    }
}
