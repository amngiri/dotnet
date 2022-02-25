using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using TFLStore.Models;
namespace TFLStore.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            return View();
        }

        //every Action method should have it's view
        public ActionResult Details(int id)
        {
            Product theProduct = null;  
            
            switch (id)
            {
                case 1:
                   theProduct = new Product
                        {
                            Id = 1,
                            Title = "Gerbera",
                            Description="Wedding Flower",
                            ImageUrl = "/images/flowers/gerbera.jpg",
                            Quantity = 1299,
                            UnitPrice = 10
                        };
                    break;
                case 2:
                    theProduct = new Product
                    {
                        Id = 1,
                        Title = "Rose",
                        Description = "Valentine Flower",
                        ImageUrl = "/images/flowers/rose.jpg",
                        Quantity = 1500,
                        UnitPrice = 16
                    };
                    break;
                case 3:
                    theProduct = new Product
                    {
                        Id = 3,
                        Title = "Lotus",
                        Description = "Worship Flower",
                        ImageUrl = "/images/flowers/lotus.jpg",
                        Quantity = 1299,
                        UnitPrice = 30
                    };
                    break;
                case 4:
                    theProduct = new Product
                    {
                        Id = 4,
                        Title = "Jasmine",
                        Description = "Best Smelling Flower",
                        ImageUrl = "/images/flowers/jasmine.jpg",
                        Quantity = 4000,
                        UnitPrice = 5
                    };
                    break;
                case 5:
                    theProduct = new Product
                    {
                        Id = 5,
                        Title = "Orhid",
                        Description = "Delicate Flower",
                        ImageUrl = "/images/flowers/orchid.jpg",
                        Quantity = 4600,
                        UnitPrice = 35
                    };
                    break;
            }
            //Transport data to View using ViewBag with its dynamic variable flower
            this.ViewBag.product = theProduct;
            return View();
        }
    }
}