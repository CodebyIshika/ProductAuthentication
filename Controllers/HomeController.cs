using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProductAuthentication.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        [Authorize]
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [Authorize]
        public ActionResult Product()
        {
            // Check if the user is authenticated
            if (!User.Identity.IsAuthenticated)
            {
                // Redirect to the login action of the AccountController in the ProductPlanner area
                return RedirectToAction("Login", "Account", new { area = "ProductPlanner" });
            }

            // Redirect to the Index action of the Product controller in the ProductPlanner area
            return RedirectToAction("Index", "Product", new { area = "ProductPlanner" });
        }
    }
}