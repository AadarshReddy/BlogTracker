using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BlogTrackerWeb.Models;

namespace BlogTrackerWeb.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        private string Model;
        public ActionResult Index()
        {
            return View(Model);
        }
        [HttpPost]
        public ActionResult AdminLogin(Admin Model)
        {
            if (ModelState.IsValid)
            {
                // Check if credentials are valid
                if (Model.Email == "admin@gmail.com" && Model.Password == "admin@123")
                {
                    // Redirect to admin dashboard or perform necessary actions
                    return RedirectToAction("Home", "Index");
                }
                else
                {
                    ModelState.AddModelError("", "Either User Name or Password Incorrect!!!");
                    return View(Model);
                }
            }
            else
            {
                return View(Model);
            }
        }
    }
}
    

