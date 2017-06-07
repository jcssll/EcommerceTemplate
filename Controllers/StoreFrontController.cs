using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AcitoEcommerce.Controllers
{
    public class StoreFrontController : Controller
    {
        // GET: StoreFront
        public ActionResult Index()
        {
            return View();
        }
    }
}