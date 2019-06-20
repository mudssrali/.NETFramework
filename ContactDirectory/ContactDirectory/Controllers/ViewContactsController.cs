using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ContactDirectory.Models;

namespace ContactDirectory.Controllers
{
    public class ViewContactsController : Controller
    {
        // GET: ViewContacts
        public ActionResult ViewContacts()
        {
            return View();
        }
    }
}