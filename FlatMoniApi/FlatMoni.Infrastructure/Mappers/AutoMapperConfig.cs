using AutoMapper;
using FlatMoniApi.FlatMoni.Infrastructure.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace FlatMoniApi.FlatMoni.Infrastructure.Mappers
{
    public static class AutoMapperConfig
    {
        public static IMapper Initialize()
        {
            var configuration = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Measure, MeasureDto>();
            }).CreateMapper();

            return configuration;
        }

    }
}
