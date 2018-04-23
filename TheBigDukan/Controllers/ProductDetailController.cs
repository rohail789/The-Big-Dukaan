using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TheBigDukan.Models;

namespace TheBigDukan.Controllers
{
  
    public class ProductDetailController : Controller
    {

        Entities1 db = new Entities1();

        #region Show Product Page       
        public ActionResult ProductDetailActionIndex(Main_Category model)
        {
           // Product p = db.Products.SingleOrDefault(g => g.category_ID == model.category_ID);
            var query = from c in db.Products
                        where c.category_ID == model.category_ID
                        select c;
           
          //  List<Product> a = db.Products.ToList();
            return View(query.ToList());
        }
        #endregion


        #region Edit Action    
        [HttpGet]
        public ActionResult EditProduct(int id)
        {
            Product p = db.Products.SingleOrDefault(g => g.product_ID == id);
            return View(p);
        }

        [HttpPost]
        public ActionResult EditProduct(Product model)
        {
            ActionResult myAction = RedirectToAction("ProductDetailActionIndex", "ProductDetail");
            try
            {
                if (ModelState.IsValid)
                {
                    db.Entry(model).State = EntityState.Modified;
                    db.SaveChanges();

                }
            }
            catch (Exception a)
            {

            }
            return myAction;
        }

        #endregion


        #region Detail Action
        public ActionResult DetailProduct(int id)
        {
            Product p = db.Products.SingleOrDefault(g => g.product_ID == id);
            return View(p);
        }
        #endregion

        [HttpGet]
        public ActionResult DeleteProduct(int id)
        {
            Product std = db.Products.SingleOrDefault(w => w.product_ID == id);
            return View(std);
        }

        [HttpPost]
        public ActionResult DeleteProduct(Product model, int id)
        {
            ActionResult myAction = RedirectToAction("ProductDetailActionIndex", "ProductDetail");
            try
            {
                if (ModelState.IsValid)
                {
                    // lb.Entry(model).State = EntityState.Deleted;
                    //  lb.Students.Remove(model);

                    Product employer = db.Products.FirstOrDefault(x => x.product_ID == id);

                    db.Products.Remove(employer);



                    db.SaveChanges();
                }

            }
            catch (Exception f)
            {
            }
            return myAction;
        }

    }
}