using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Top10Covid19Cases;
using Top10Covid19Cases.Controllers;
using Top10Covid19Cases.Interfaces;
using Top10Covid19Cases.Utils;

namespace Top10Covid19Cases.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public async System.Threading.Tasks.Task Index()
        {
            var IEndPointHandler = new Mock<IEndPointHandler>();
            IEndPointHandler.SetupGet(p => p.uri).Returns("https://covid-19-statistics.p.rapidapi.com/");
            IEndPointHandler.SetupGet(p => p.x_rapidapi_host).Returns("covid - 19 - statistics.p.rapidapi.com");
            IEndPointHandler.SetupGet(p => p.x_rapidapi_key).Returns("74dda8e1damsh5bfe9ff59b037e5p102674jsn28c1c4251ffd");

            var requestHandler = new Mock<RequestHandler>();
            // Arrange
            HomeController controller = new HomeController(requestHandler.Object);

            // Act
            ViewResult result = await controller.Index() as ViewResult;
            //String result = controller.Index() as String;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void About()
        {
            var requestHandler = new Mock<RequestHandler>();
            // Arrange
            HomeController controller = new HomeController(requestHandler.Object);

            // Act
            ViewResult result = controller.About() as ViewResult;

            // Assert
            Assert.AreEqual("Your application description page.", result.ViewBag.Message);
        }

        [TestMethod]
        public void Contact()
        {
            var requestHandler = new Mock<RequestHandler>();
            // Arrange
            HomeController controller = new HomeController(requestHandler.Object);

            // Act
            ViewResult result = controller.Contact() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }
    }
}
