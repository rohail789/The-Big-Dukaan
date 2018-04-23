using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TheBigDukan.Models;
namespace TheBigDukan.Controllers
{
    public class ClientController : Controller
    {
        Entities1 db = new Entities1();
        // GET: Client
        public ActionResult ClientProducts(Main_Category maincat)

        {
            var query = from c in db.Products
                        where c.category_ID == maincat.category_ID
                        select c;

            return View(query.ToList());
        }
    }
}