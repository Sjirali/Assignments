using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PartialViewAsgnmnt.Models;

namespace PartialViewAsgnmnt.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }
        public ActionResult htmlPartial()
        {
            ViewBag.Message = "HTML Partial View Example";
            List<Models.Product> products = new List<Models.Product>()
            {
                new Models.Product { ProductID =1, Name ="Product 1", Category = "Category 1", Description ="Description 1", Price = 10m},
                new Models.Product { ProductID =2, Name ="Product 2", Category = "Category 1", Description ="Description 2", Price = 20m},
                new Models.Product { ProductID =3, Name ="Product 3", Category = "Category 1", Description ="Description 3", Price = 30m},
                new Models.Product { ProductID =4, Name ="Product 4", Category = "Category 2", Description ="Description 4", Price = 40m},
                new Models.Product { ProductID =5, Name ="Product 5", Category = "Category 2", Description ="Description 5", Price = 50m},
                new Models.Product { ProductID =6, Name ="Product 6", Category = "Category 2", Description ="Description 6", Price = 50m}
            };
            return View(products);
        }

        public ActionResult htmlRenderPartial()
        {
            ViewBag.Message = "HTML Render Partial View Example";
            List<Models.Product> products = new List<Models.Product>()
            {
                new Models.Product { ProductID =1, Name ="Product 1", Category = "Category 1", Description ="Description 1", Price = 10m},
                new Models.Product { ProductID =2, Name ="Product 2", Category = "Category 1", Description ="Description 2", Price = 20m},
                new Models.Product { ProductID =3, Name ="Product 3", Category = "Category 1", Description ="Description 3", Price = 30m},
                new Models.Product { ProductID =4, Name ="Product 4", Category = "Category 2", Description ="Description 4", Price = 40m},
                new Models.Product { ProductID =5, Name ="Product 5", Category = "Category 2", Description ="Description 5", Price = 50m},
                new Models.Product { ProductID =6, Name ="Product 6", Category = "Category 2", Description ="Description 6", Price = 50m}
            };
            return View(products);
        }
        [ChildActionOnly]
        public ActionResult htmlRenderAction()
        {
            ViewBag.Message = "HTML Render Action View Example";
            List<Models.Product> products = new List<Models.Product>()
            {
                new Models.Product { ProductID =1, Name ="Product 1", Category = "Category 1", Description ="Description 1", Price = 10m},
                new Models.Product { ProductID =2, Name ="Product 2", Category = "Category 1", Description ="Description 2", Price = 20m},
                new Models.Product { ProductID =3, Name ="Product 3", Category = "Category 1", Description ="Description 3", Price = 30m},
                new Models.Product { ProductID =4, Name ="Product 4", Category = "Category 2", Description ="Description 4", Price = 40m},
                new Models.Product { ProductID =5, Name ="Product 5", Category = "Category 2", Description ="Description 5", Price = 50m},
                new Models.Product { ProductID =6, Name ="Product 6", Category = "Category 2", Description ="Description 6", Price = 50m}
            };
            //return View (products);
            return PartialView("ProductDetails", products);
        }
    }
}