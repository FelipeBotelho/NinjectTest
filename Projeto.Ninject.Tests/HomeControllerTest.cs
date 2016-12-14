using System;
using NUnit;
using NUnit.Framework;
using Moq;
using Projeto.Ninject.Service.Interfaces;
using Projeto_Ninject.Controllers;
using System.Web.Mvc;

namespace Projeto.Ninject.Tests
{
    [TestFixture]
    public class HomeControllerTest
    {
        [Test]
        public void HomeIndexTest()
        {
            var homeService = new Mock<IHomeService>();
            var enterpriseService = new Mock<IEnterpriseService>();
            homeService.Setup(x => x.GetInformations()).Returns(new Contratos.HomeContract());
            enterpriseService.Setup(x => x.GetInformations()).Returns(new Contratos.EnterpriseContract());
            var controller = new HomeController(homeService.Object, enterpriseService.Object);
            var result = controller.Index() as ViewResult;
            Assert.AreEqual(result.ViewName, "Index");
        }
    }
}
