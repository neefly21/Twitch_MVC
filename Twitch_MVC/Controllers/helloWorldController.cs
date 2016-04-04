using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Twitch_MVC.Controllers
{
    public class helloWorldController : Controller
    {
        // GET: helloWorld
        public ActionResult Index()
        {
            return View();
        }
    }
}