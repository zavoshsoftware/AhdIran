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
                Customers = db.Customers.Where(c => c.IsDeleted == false && c.IsActive).Take(8).ToList(),
                Sliders = db.Sliders.Where(c => c.IsDeleted == false && c.IsActive).OrderBy(c => c.Order).ToList(),
                Sec2Col1 = GetText("sec2-col1", "summery"),
                Sec2Col2 = GetText("sec2-col2", "body"),
                Sec2Col3 = GetText("sec2-col3", "body"),
                ServiceText = GetText("home-service-text", "body"),
                Features = db.TextItems.Where(c=>c.TextItemType.TypeName== "home-features" && c.IsDeleted==false).ToList(),
                Process = db.TextItems.Where(c=>c.TextItemType.TypeName== "home-proccess" && c.IsDeleted==false).OrderBy(c=>c.Name).ToList(),
                Values = db.TextItems.Where(c=>c.TextItemType.TypeName== "home-value" && c.IsDeleted==false).OrderBy(c=>c.Name).ToList(),
                Address = GetText("address", "body"),
                Phone = GetText("phone", "summery"),
                Email = GetText("email", "summery"),
                Instagram = GetText("insta", "summery"),
                Telegram = GetText("telegram", "summery"),
            };
            return View(result);
        }

        public string GetText(string urlParam, string field)
        {
            TextItem textItem = db.TextItems.FirstOrDefault(c => c.Name == urlParam);

            if (textItem != null)
            {
                if (field == "summery")
                    return textItem.Summery;
                if (field == "body")
                    return textItem.Body;
                if (field == "imageurl")
                    return textItem.ImageUrl;
                if (field == "title")
                    return textItem.Title;
            }

            return String.Empty;
        }
        [Route("about")]
        public ActionResult About()
        {
            AboutViewModel result = new AboutViewModel()
            {
                Customers = db.Customers.Where(c => c.IsDeleted == false && c.IsActive).Take(8).ToList()
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
        public ActionResult AdslPriceList()
        {
            _BaseViewModel model = new _BaseViewModel();
            return View(model);
        }
        public ActionResult WifiPriceList()
        {
            _BaseViewModel model = new _BaseViewModel();
            return View(model);
        }
    }
}