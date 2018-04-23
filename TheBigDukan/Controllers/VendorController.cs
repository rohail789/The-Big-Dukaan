using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TheBigDukan.Models;
namespace TheBigDukan.Controllers
{

    public class VendorController : Controller
    {
        Entities1 db = new Entities1();

        public string Elect { get; private set; }

        // GET: Vendor
        public ActionResult VenderActionIndex(SignUpModel model)
        {
            SignUpModel.sharedInstance = model;
            return View(model);
        }

        #region Electronic     
        public ActionResult Electronic()
        {
            ActionResult myaction = RedirectToAction("ProductDetailActionIndex", "ProductDetail");
            string Elect = "Electronics";
           
            try
            {
               Main_Category maincat = db.Main_Category.Single(w => w.cat_Data == Elect );
               // var a = db.Main_Category.Where(w => w.Cat_Name.StartsWith(Elect)).ToList();
               
                if (maincat != null)
                {
                    
                    Session["CategoryOBj"] = maincat;
                    if (SignUpModel.sharedInstance.UserType == null)
                    {
                        myaction = RedirectToAction("ClientProducts", "Client", maincat);
                    }
                    else {
                        if (SignUpModel.sharedInstance.UserType == "Vendor")
                        {
                            myaction = RedirectToAction("ProductDetailActionIndex", "ProductDetail", maincat);
                        }
                        else
                        {
                            myaction = RedirectToAction("ClientProducts", "Client", maincat);
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
            return myaction;
        }
        #endregion

        #region PhonesNTablets  
        public ActionResult PhonesNTablets()
        {
            ActionResult myaction = RedirectToAction("ProductDetailActionIndex", "ProductDetail");
            string Item = "PhonesNTablets";

            try
            {
                Main_Category maincat = db.Main_Category.Single(w => w.cat_Data == Item);
                // var a = db.Main_Category.Where(w => w.Cat_Name.StartsWith(Elect)).ToList();

                if (maincat != null)
                {

                    Session["CategoryOBj"] = maincat;

                    if (SignUpModel.sharedInstance.UserType == null)
                    {
                        myaction = RedirectToAction("ClientProducts", "Client", maincat);
                    }
                    else {
                        if (SignUpModel.sharedInstance.UserType == "Vendor")
                        {
                            myaction = RedirectToAction("ProductDetailActionIndex", "ProductDetail", maincat);
                        }
                        else
                        {
                            myaction = RedirectToAction("ClientProducts", "Client", maincat);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
            return myaction;
        }
        #endregion

        #region BabyNToysNKidsion     
        public ActionResult BabyNToysNKids()
        {
            ActionResult myaction = RedirectToAction("ProductDetailActionIndex", "ProductDetail");
            string Item = "BabyNToysNKids";

            try
            {
                Main_Category maincat = db.Main_Category.Single(w => w.cat_Data == Item);
                // var a = db.Main_Category.Where(w => w.Cat_Name.StartsWith(Elect)).ToList();

                if (maincat != null)
                {

                    Session["CategoryOBj"] = maincat;
                    if (SignUpModel.sharedInstance.UserType == null)
                    {
                        myaction = RedirectToAction("ClientProducts", "Client", maincat);
                    }
                    else {
                        if (SignUpModel.sharedInstance.UserType == "Vendor")
                        {
                            myaction = RedirectToAction("ProductDetailActionIndex", "ProductDetail", maincat);
                        }
                        else
                        {
                            myaction = RedirectToAction("ClientProducts", "Client", maincat);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
            return myaction;
        }
        #endregion

        #region WomenNFashion     
        public ActionResult WomenNFashion()
        {
            ActionResult myaction = RedirectToAction("ProductDetailActionIndex", "ProductDetail");
            string Item = "WomenNFashion";

            try
            {
                Main_Category maincat = db.Main_Category.Single(w => w.cat_Data == Item);
                // var a = db.Main_Category.Where(w => w.Cat_Name.StartsWith(Elect)).ToList();

                if (maincat != null)
                {

                    Session["CategoryOBj"] = maincat;

                    if (SignUpModel.sharedInstance.UserType == null)
                    {
                        myaction = RedirectToAction("ClientProducts", "Client", maincat);
                    }
                    else {
                        if (SignUpModel.sharedInstance.UserType == "Vendor")
                        {
                            myaction = RedirectToAction("ProductDetailActionIndex", "ProductDetail", maincat);
                        }
                        else
                        {
                            myaction = RedirectToAction("ClientProducts", "Client", maincat);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
            return myaction;
        }
        #endregion

        #region GroceryShop     
        public ActionResult GroceryShop()
        {
            ActionResult myaction = RedirectToAction("ProductDetailActionIndex", "ProductDetail");
            string Item = "GroceryShop";

            try
            {
                Main_Category maincat = db.Main_Category.Single(w => w.cat_Data == Item);
                // var a = db.Main_Category.Where(w => w.Cat_Name.StartsWith(Elect)).ToList();

                if (maincat != null)
                {

                    Session["CategoryOBj"] = maincat;

                    if (SignUpModel.sharedInstance.UserType == null)
                    {
                        myaction = RedirectToAction("ClientProducts", "Client", maincat);
                    }
                    else {
                        if (SignUpModel.sharedInstance.UserType == "Vendor")
                        {
                            myaction = RedirectToAction("ProductDetailActionIndex", "ProductDetail", maincat);
                        }
                        else
                        {
                            myaction = RedirectToAction("ClientProducts", "Client", maincat);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
            return myaction;
        }
        #endregion


        #region Electronic     
        public ActionResult Vegetable()
        {
            ActionResult myaction = RedirectToAction("ProductDetailActionIndex", "ProductDetail");
            string Elect = "Vegetable";

            try
            {
                Main_Category maincat = db.Main_Category.Single(w => w.cat_Data == Elect);
                // var a = db.Main_Category.Where(w => w.Cat_Name.StartsWith(Elect)).ToList();

                if (maincat != null)
                {

                    Session["CategoryOBj"] = maincat;
                    if (SignUpModel.sharedInstance.UserType == null)
                    {
                        myaction = RedirectToAction("ClientProducts", "Client", maincat);
                    }
                    else {
                        if (SignUpModel.sharedInstance.UserType == "Vendor")
                        {
                            myaction = RedirectToAction("ProductDetailActionIndex", "ProductDetail", maincat);
                        }
                        else
                        {
                            myaction = RedirectToAction("ClientProducts", "Client", maincat);
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
            return myaction;
        }
        #endregion
        public ActionResult LogOut() {

            ActionResult myaction = RedirectToAction("VenderActionIndex", "Vendor");
            return myaction;
        }
    }
}