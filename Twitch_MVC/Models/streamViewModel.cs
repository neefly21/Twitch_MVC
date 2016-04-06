using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Twitch_MVC.Models
{
    public class streamViewModel
    {
        public IEnumerable<SelectListItem> streams;
        public IEnumerable<SelectListItem> selectedStream;
    }
}