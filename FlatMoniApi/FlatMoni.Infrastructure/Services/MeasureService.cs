using AutoMapper;
using FlatMoniApi.FlatMoni.Infrastructure.DTO;
using FlatMoniApi.Repositories;
using System;

namespace FlatMoniApi.FlatMoni.Infrastructure.Services
{
    class MeasureService : IMeasureService
    {
        private readonly IMeasureRepository _measureRepository;

        private readonly IMapper _mapper;

        public MeasureService(IMeasureRepository measureRepository, IMapper mapper)
        {
            _measureRepository = measureRepository;
            _mapper = mapper;
        }

        public MeasureDto Get(string name)
        {
            var measure = _measureRepository.Get(name);

            return _mapper.Map<Measure, MeasureDto>(measure);
        }

        public void Record(string name, float value, string unit, DateTime date)
        {
            var measure = new Measure(name, value, unit, date);

            _measureRepository.Add(measure);
        }
    }
}
