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
            return View();
        }
        [HttpPost]
        public ActionResult Index(maintenance_req mr)
        {
            using (Model1 context = new Model1())
            {
                context.Maintenance_Reqs.Add(mr);
                context.SaveChanges();
            }
            return View();
        }
    }
}