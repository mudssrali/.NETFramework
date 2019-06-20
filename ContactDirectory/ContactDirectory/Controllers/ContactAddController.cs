using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ContactDirectory.Models;

namespace ContactDirectory.Controllers
{
    public class ContactAddController : Controller
    {
        // GET: ContactAdd
        [HttpGet]
        public ActionResult ContactAdd ( )
        {
            ViewBag.MsgResponse = TempData["Message"]!=null?TempData["Message"].ToString():"";
            return View();
        }
        
        // POST: ContactAdd
        [HttpPost]
        public ActionResult SaveContact ( ModelManager dto )
        {
            int ret = save( dto );

            TempData["Message"]  = ret == 1 ? "New contact added successfully" : "unable to add new contact";
    
            return RedirectToAction("ContactAdd","ContactAdd");
        }

        private Int32 save ( ModelManager dto )
        {
            //using string interpolation technique to make prepared query

            var query = $"INSERT dbo.contacts(Name,Email,Phone) VALUES('{dto.Name}','{dto.Email}','{dto.Phone}')";

            // using string.format
            //var query = String.Format( "ISNERT dbo.contacts(Name,Email,Phone) VALUES('{0}','{1},'{2}')", dto.Name, dto.Email, dto.Phone );

            // to safely desposing db object
            using (var helper = new DBHelper())
            {
                return helper.ExecuteQuery( query );
            }

        }

    }
}