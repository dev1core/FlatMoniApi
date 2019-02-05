using AutoMapper;
using FlatMoni.Core.Domain;
using FlatMoni.Core.Repositories;
using FlatMoniApi.FlatMoni.Infrastructure.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Threading.Tasks;

namespace FlatMoniApi.Tests.Services
{
    [TestClass]
    public class MeasureServiceTest
    {

        [TestMethod]
        public async Task MesureTest()
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
