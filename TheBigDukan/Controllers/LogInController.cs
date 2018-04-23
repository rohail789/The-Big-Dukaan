using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TheBigDukan.Models;

namespace TheBigDukan.Controllers
{
    public class LogInController : Controller
    {
        Entities1 db = new Entities1();

        public string FileName { get; private set; }

        // GET: LogIn
        [HttpGet]
        public ActionResult LogInAction()
        {
            return View();
        }

        [HttpPost]
        public ActionResult LogInAction(Registration myLoginModel)
            
        {
            
            ActionResult myaction = RedirectToAction("VenderActionIndex", "Vendor");
            string id = myLoginModel.email;
            string pass = myLoginModel.password;
            if (id != null && pass != null)
            {
                try
                {
                    Registration regform = db.Registrations.Single(w => w.email == id && w.password == pass);
                  //  Response.Write(regform.name);
                    if (ModelState.IsValid)
                    {
                        if (regform == null)
                        {
                            
                           // myLoginModel.ErrorMsg = "not found";
                            myaction = View(myLoginModel);
                        }
                        else
                        {
                            SignUpModel mod = new SignUpModel(regform);


                             myaction = RedirectToAction("VenderActionIndex", "Vendor",mod);
                         

                        }
                    }
                }
                catch (Exception )
                {
                 //   myLoginModel.ErrorMsg = "not found";
                    myaction = View(myLoginModel);
                }
            }
            else
            {
                myaction = View();

            }
            return myaction;
        }
       
        [HttpGet]
      public ActionResult SignUpView()
        {
            return View();
        }
        [HttpPost]
        public ActionResult SignUpView(Registration mymodelSignUp)

        {
            ActionResult myaction = RedirectToAction("VenderActionIndex", "Vendor");

            try
            {

                //regform.name = mymodelSignUp.name;
                //regform.email = mymodelSignUp.email;
                //regform.address = mymodelSignUp.address;
                //regform.cellNo = mymodelSignUp.cellNo
                //regform.password = mymodelSignUp.password;
                //regform.userType = mymodelSignUp.userType
                //regform.time = Convert.ToString(DateTime.Now.Date);
                //if (mymodelSignUp.userType == "Vendor")
                //{
                //    regform.isActive = false;
                //}
                //else
                //{
                //    regform.isActive = true;
                //}

                //#region Save Image on Server
               

                string FileName = Path.GetFileNameWithoutExtension(mymodelSignUp.Image_new.FileName);
                string Extension = Path.GetExtension(mymodelSignUp.Image_new.FileName);
                FileName = FileName + DateTime.Now.ToString("yymmssff") + Extension;
                mymodelSignUp.Image = "~/Pictures/" + FileName;

                FileName = Path.Combine(Server.MapPath("~/Pictures/"), FileName);

                mymodelSignUp.Image_new.SaveAs(FileName);

                db.Registrations.Add(mymodelSignUp);
                db.SaveChanges();
                myaction = RedirectToAction("VenderActionIndex", "Vendor", mymodelSignUp);
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
               
            }


            return myaction;
        }
       
    }
}