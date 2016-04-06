using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Twitch_MVC.Controllers
{
    public class MainController : Controller
    {

        static String test = "test";

        public ActionResult Index()
        {
            


            return View();
        }

        public ActionResult activeStreams()
        {
            return View();
        }
    }
}