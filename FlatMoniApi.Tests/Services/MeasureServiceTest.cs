using AutoMapper;
using FlatMoni.Core.Domain;
using FlatMoni.Core.Repositories;
using FlatMoniApi.FlatMoni.Infrastructure.Services;
using Moq;
using System;
using System.Threading.Tasks;
using Xunit;

namespace FlatMoniApi.Tests.Services
{
    
    public class MeasureServiceTest
    {

        [Fact]
        public async Task measureRecordAsyncTimesOnece()
        {
            //measure mock 
            var measureRepositoryMock = new Mock<IMeasureRepository>();
            var mapperMock = new Mock<IMapper>();

            var measureService = new MeasureService(measureRepositoryMock.Object, mapperMock.Object);

            await measureService.RecordAsync("Flat temperature", 24, "C", DateTime.Now);

            measureRepositoryMock.Verify(x => x.AddAsync(It.IsAny<Measure>()), Times.Once);
        }

    }
}
