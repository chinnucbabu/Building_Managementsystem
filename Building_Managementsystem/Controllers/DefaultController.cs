using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Building_Managementsystem.Models;


namespace Building_Managementsystem.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(user_reg ur)
        {
            using (Model1 context = new Model1() )
            {
                context.user_reg.Add(ur);
                context.SaveChanges();
                
            }
            return RedirectToAction("Login");
            return View();
        }
        public ActionResult Maintenancerequest()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Maintenancerequest(maintenance_req mr)
        {
            using (Model1 context = new Model1())
            {
                context.maintenance_req.Add(mr);
                context.SaveChanges();
                return RedirectToAction("Maintanencerequest");

            }
            //string message = "Created the record successfully";
            //ViewBag.Message = message;
            return View();
        }
        public ActionResult Login()

        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(user_reg usr)
        {
            if (ModelState.IsValid)
            {
                using (Model1 context = new Model1())
                {
                    var obj= context.user_reg.Where(a=>a.username.Equals(usr.username)&& a.password_.Equals(usr.password_)).FirstOrDefault();
                    if(obj!=null)
                    {
                        if (obj.isadmin)
                        {
                            return RedirectToAction("View");
                        }
                        else
                        {
                            return RedirectToAction("Maintenancerequest");
                        }
                    }





                    context.user_reg.Add(usr);
                    context.SaveChanges();
                }
            }
            return View();
        }
        public ActionResult Delete()

        {
            return View();
        }

        [HttpPost]
        public ActionResult Delete(maintenance_req del)

        {
            using (Model1 context = new Model1())
            {
                
                context.maintenance_req.Add(del);
                context.SaveChanges();
            }

            return View();
        }







    }
}