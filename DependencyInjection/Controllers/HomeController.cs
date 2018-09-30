using DependencyInjection.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DependencyInjection.Controllers
{
    public class HomeController : Controller
    {
        private IValueService _valuesService;

        public HomeController(IValueService valuesService)
        {
            _valuesService = valuesService;
        }

        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }
    }
}
