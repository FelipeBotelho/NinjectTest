using Moq;
using NUnit.Framework;
using Projeto.Ninject.Business.Interfaces;
using Projeto.Ninject.Service;
using Projeto.Ninject.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Ninject.Tests
{
    [TestFixture]
    public class HomeServiceTest
    {
        [Test]
        public void GetHomeInformationsService()
        {
            var business = new Mock<IHomeBusiness>();
            business.Setup(x => x.GetInformations()).Returns(new Contratos.HomeContract() { Age = 19, Name = "teste" });
            var service = (IHomeService)new HomeService(business.Object);
            var result = service.GetInformations();
            Assert.AreEqual(result.Age, 19);
            Assert.AreEqual(result.Name, "teste");
        }
    }
}
