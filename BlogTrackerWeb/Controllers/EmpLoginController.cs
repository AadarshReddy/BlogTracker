using BlogTrackerWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlogTrackerWeb.Controllers
{
    public class EmpLoginController : Controller
    {
        // GET: EmpLogin
        
        private string Model;
        public ActionResult Index()
        {
            return View(Model);
        }
        [HttpPost]
        public ActionResult EmpLogin(EmpLogin emp)
        {
            if (ModelState.IsValid)
            {
                // Check if credentials are valid
                if (emp.Email == "admin@gmail.com" && emp.PassCode == 123456)
                {
                    // Redirect to admin dashboard or perform necessary actions
                    return RedirectToAction("Blogs", "Index");
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


