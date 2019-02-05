using AutoMapper;
using FlatMoni.Core.Domain;
using FlatMoniApi.FlatMoni.Infrastructure.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace FlatMoniApi.FlatMoni.Infrastructure.Mappers
{
    public static class AutoMapperConfig
    {
        public static IMapper Initialize()
         => new MapperConfiguration(cfg =>
           {
               cfg.CreateMap<Measure, MeasureDto>();
           }).CreateMapper();
    }
}
