using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ContactDirectory.Controllers
{
    public class HomeViewController : Controller
    {
        public ActionResult HomeView ( )
        {
            return View();
        }

    }
}