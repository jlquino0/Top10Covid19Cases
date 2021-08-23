using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Top10Covid19Cases;
using Top10Covid19Cases.Controllers;
using Top10Covid19Cases.Models;
using Top10Covid19Cases.Interfaces;
using Top10Covid19Cases.Utils;
using Top10Covid19Cases.Implementation;
using System.Threading.Tasks;

namespace Top10Covid19Cases.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public async System.Threading.Tasks.Task Index()
        {

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
        public void Regions()
        {
            var IEndPointHandler = new Mock<IEndPointHandler>();
            IEndPointHandler.SetupGet(p => p.uri).Returns("https://covid-19-statistics.p.rapidapi.com/");
            IEndPointHandler.SetupGet(p => p.x_rapidapi_host).Returns("covid - 19 - statistics.p.rapidapi.com");
            IEndPointHandler.SetupGet(p => p.x_rapidapi_key).Returns("74dda8e1damsh5bfe9ff59b037e5p102674jsn28c1c4251ffd");
            // Arrange
            RequestHandler requestHandler = new RequestHandler(IEndPointHandler.Object);

            // Act
            Task<List<SelectListItem>> result = requestHandler.Handle(new Region()) as Task<List<SelectListItem>>;

            // Assert
            //Assert.AreEqual("Your application description page.", result.ViewBag.Message);
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void Reporte()
        {
            var IEndPointHandler = new Mock<IEndPointHandler>();
            IEndPointHandler.SetupGet(p => p.uri).Returns("https://covid-19-statistics.p.rapidapi.com/");
            IEndPointHandler.SetupGet(p => p.x_rapidapi_host).Returns("covid - 19 - statistics.p.rapidapi.com");
            IEndPointHandler.SetupGet(p => p.x_rapidapi_key).Returns("74dda8e1damsh5bfe9ff59b037e5p102674jsn28c1c4251ffd");
            // Arrange
            RequestHandler requestHandler = new RequestHandler(IEndPointHandler.Object);

            // Act
            Task<List<Reporte>> result = requestHandler.Handle(new Reporte()) as Task<List<Reporte>>;

            // Assert
            //Assert.AreEqual("Your application description page.", result.ViewBag.Message);
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void ReporteProvince()
        {
            var IEndPointHandler = new Mock<IEndPointHandler>();
            IEndPointHandler.SetupGet(p => p.uri).Returns("https://covid-19-statistics.p.rapidapi.com/");
            IEndPointHandler.SetupGet(p => p.x_rapidapi_host).Returns("covid - 19 - statistics.p.rapidapi.com");
            IEndPointHandler.SetupGet(p => p.x_rapidapi_key).Returns("74dda8e1damsh5bfe9ff59b037e5p102674jsn28c1c4251ffd");
            // Arrange
            RequestHandler requestHandler = new RequestHandler(IEndPointHandler.Object);

            Province province = new Province();
            province.iso = "CHN";

            // Act
            Task<List<ReporteProvince>> result = requestHandler.Handle(province) as Task<List<ReporteProvince>>;

            // Assert
            //Assert.AreEqual("Your application description page.", result.ViewBag.Message);
            Assert.IsNotNull(result);
        }
    }
}
