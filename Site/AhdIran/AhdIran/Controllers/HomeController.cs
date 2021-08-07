using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Models;
using ViewModels;

namespace AhdIran.Controllers
{
    public class HomeController : Controller
    {
       
        private DatabaseContext db = new DatabaseContext();
        public ActionResult Index()
        {
            HomeViewModel result = new HomeViewModel()
            {
                Customers = db.Customers.Where(c => c.IsDeleted == false && c.IsActive).Take(8).ToList()
              ,  Sliders = db.Sliders.Where(c => c.IsDeleted == false && c.IsActive).OrderBy(c=>c.Order).ToList()
            };
            return View(result);
        }
        [Route("about")]
        public ActionResult About()
        {
            AboutViewModel result = new AboutViewModel()
            {
                Customers = db.Customers.Where(c=>c.IsDeleted==false&&c.IsActive).Take(8).ToList()
            };
            return View(result);
        }

        [Route("Contact")]
        public ActionResult Contact()
        {
            ContactViewModel result = new ContactViewModel()
            {
                //  Customers = db.Customers.Where(c=>c.IsDeleted==false&&c.IsActive).Take(8).ToList()
            };
            return View(result);
        }
    }
}