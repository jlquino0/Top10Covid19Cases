using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;
using Top10Covid19Cases.Implementation;
using Top10Covid19Cases.Interfaces;
using Top10Covid19Cases.Models;
using Top10Covid19Cases.Utils;

namespace Top10Covid19Cases.Controllers
{
    public class HomeController : Controller
    {
        RequestHandler _requestHandler;
        public HomeController(RequestHandler requestHandler)
        {
            _requestHandler = requestHandler;
        }
        public async System.Threading.Tasks.Task<ActionResult> Index()
        {
            ViewBag.RegionList = await _requestHandler.Handle(new Region());
            return View(await _requestHandler.Handle(new Reporte()));
        }

        [HttpPost]
        public async System.Threading.Tasks.Task<ActionResult> Index(FormCollection form)
        {
            string strDDLValue = form["RegionList"].ToString();
            ViewBag.RegionList = await _requestHandler.Handle(new Region());
            Province reporte = new Province();
            //reporte.province = new Province();
            reporte.iso= strDDLValue;
            return View("Province",await _requestHandler.Handle(reporte));
        }


        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}