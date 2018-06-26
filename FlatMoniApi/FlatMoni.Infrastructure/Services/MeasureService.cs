using FlatMoniApi.FlatMoni.Infrastructure.DTO;
using FlatMoniApi.Repositories;
using System;

namespace FlatMoniApi.FlatMoni.Infrastructure.Services
{
    class MeasureService : IMeasureService
    {
        private readonly IMeasureRepository _measureRepository;

        public MeasureService(IMeasureRepository measureRepository)
        {
            _measureRepository = measureRepository;

        }

        public MeasureDto Get(string name)
        {
            var measure = _measureRepository.Get(name);
            return new MeasureDto {
                Id = measure.Id,
                Date = measure.Date,
                Name = measure.Name,
                Unit = measure.Unit,
                Value = measure.Value
            };
        }

        public void Record(string name, float value, string unit, DateTime date)
        {
            var measure = new Measure(name, value, unit, date);

            _measureRepository.Add(measure);
        }
    }
}
