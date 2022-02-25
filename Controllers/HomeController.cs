using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TFLStore.Controllers
{
    public class HomeController : Controller
    {

        //Set of Action Methods
        //Action methods are always mapped to HTTP request  types
        //GET, POST, PUT, DELETE (HTTP verbs)
        // GET: Home
        [HttpGet]
        public ActionResult Index()
        { 
            this.Response.Write("<hr/>Session ID " + Session.SessionID.ToString());
            return View();
        }

        [HttpGet]
        public ActionResult Aboutus()
        {
            this.Response.Write("<hr/>Session ID " + Session.SessionID.ToString());
            return View();
        }


        [HttpGet]
        public ActionResult Contact()
        {
            return View();
        }
    }
}