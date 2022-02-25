using System;
using System.Collections.Generic;
using System.Linq;
//using System.Security.Policy;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

using TFLStore.Models;
namespace TFLStore
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
         {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }

        protected void Session_Start()
        {
            //Creating empty cart
            Cart cart = new Cart();
            //Attaching cart to the session maintaineg by app at server.
            this.Session["shoppingcart"] = cart;
        }

        protected void Application_BeginRequest(object sender, EventArgs e)
         {
            Uri theUrl = Request.Url;
            string url = theUrl.ToString();
            HttpCookieCollection cookies=Request.Cookies;
        }

        protected void Application_EndRequest(object sender, EventArgs e)
        { 
            Response.Write("<hr/>This page was served at " +DateTime.Now.ToString());
           
        }
        protected void Session_End()
        {
            //Cart cart = (Cart)this.Session["shoppingcart"];
            //cart = null;
            this.Session.Clear();
        }
    }
}
