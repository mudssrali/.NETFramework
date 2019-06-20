using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
            // using model approach, viewbag can be used instead
            var contactList = GetAllContacts();
            
            return View(contactList);
        }

        private List<ModelManager> GetAllContacts ( )
        {
            var query = "SELECT * FROM dbo.contacts";

            using (var helper = new DBHelper())
            {
                var reader = helper.ExecuteReader( query );

                List<ModelManager> list = new List<ModelManager>();
                while (reader.Read())
                {
                    ModelManager dto = new ModelManager();
                    dto = FillDTO( reader );
                    list.Add( dto );
                }
                return list;
            }
        }

        private ModelManager FillDTO ( SqlDataReader reader )
        {
            var dto = new ModelManager();
            dto.ID = reader.GetInt32( 0 );
            dto.Name = reader.GetString( 1 );
            dto.Email = reader.GetString( 2 );
            dto.Phone = reader.GetString( 3 );

            return dto;
        }
    }
}