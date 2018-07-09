using System;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace FlatMoniApiEndToEndTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public async Task TestMethod1()
        {
            var measureRepository = new Mock<IMeasureRepository>();
            var mapper = new Mock<IMapper>();


            var measureSerivce = new MeasureService();

        }
    }
}
