using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TFLStore.Models;
namespace TFLStore.Controllers
{
    public class ShoppingCartController : Controller
    {
        // GET: ShoppingCart
        public ActionResult Index()
        {

            //Get all shopping cart items from session maintained for user
            Cart cartForUser = (Cart)this.Session["shoppingcart"];
            List<Item> allItems = cartForUser.GetAllItems();
            ViewBag.cart = allItems;

            return View();
        }

        public ActionResult AddToCart(int id)
        {
            Item item = new Item();
            item.ProductId = id;
            item.Quantity = 0;
            ViewBag.item = item;
            return View();
        }

        [HttpPost]
        public ActionResult AddToCart(int id, int quantity)
        {
            Cart cartForUser = (Cart)this.Session["shoppingcart"];
            Item newItem = new Item();
            newItem.ProductId = id;
            newItem.Quantity = quantity;
            cartForUser.AddToCart(newItem);
            return RedirectToAction("index", "Product");
            //return View();
        }
        public ActionResult Edit(int id)
        {
            //get item from cart maintained inside session whose ProductId matching with id parameter

            Cart cartForUser = (Cart)this.Session["shoppingcart"];
            List<Item> allItems = cartForUser.GetAllItems();
            Item updatedItem = allItems.Find((theItem) => theItem.ProductId == id);
            
            //tranport the item for editing to view

            ViewBag.item = updatedItem;
            return View();
        }

        [HttpPost]
        public ActionResult Edit(int id, int quantity)
        {
            Item updatedItem = new Item();
            updatedItem.ProductId = id;
            updatedItem.Quantity = quantity;

            //get item from cart maintained inside session whose ProductId matching with id parameter
            Cart cartForUser = (Cart)this.Session["shoppingcart"];
            List<Item> allItems = cartForUser.GetAllItems();
            Item existingItem = allItems.Find((theItem) => theItem.ProductId == id);

            //Replace its quantity maintained inside items of cart  of Session for the User
            existingItem.Quantity = quantity;
            return RedirectToAction("index", "Shoppingcart");
        }
        public ActionResult Remove(int id)
        {

            //get item from cart maintained inside session whose ProductId matching with id parameter
            Cart cartForUser = (Cart)this.Session["shoppingcart"];
            List<Item> allItems = cartForUser.GetAllItems();
            Item existingItem = allItems.Find((theItem) => theItem.ProductId == id);
            allItems.Remove(existingItem);
            return RedirectToAction("Index", "Shoppingcart");
        }
    }
}