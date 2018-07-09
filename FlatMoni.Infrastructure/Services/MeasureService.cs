using AutoMapper;
using FlatMoniApi.FlatMoni.Infrastructure.DTO;
using FlatMoni.Core.Repositories;
using System;
using System.Threading.Tasks;
using FlatMoni.Core.Domain;

namespace FlatMoniApi.FlatMoni.Infrastructure.Services
{
    public class MeasureService : IMeasureService
    {
        private readonly IMeasureRepository _measureRepository;

        private readonly IMapper _mapper;

        public MeasureService(IMeasureRepository measureRepository, IMapper mapper)
        {
            _measureRepository = measureRepository;
            _mapper = mapper;
        }

        public async Task<MeasureDto> GetAsync(string name)
        {
            var measure = await _measureRepository.GetAsync(name);

            return _mapper.Map<Measure, MeasureDto>(measure);
        }

        public async Task RecordAsync(string name, float value, string unit, DateTime date)
        {
            var measure = new Measure(name, value, unit, date);

            await _measureRepository.AddAsync(measure);
        }
    }
}
