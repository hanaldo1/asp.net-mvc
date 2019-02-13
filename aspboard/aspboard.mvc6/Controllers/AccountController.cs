using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using aspboard.mvc6.DataContext;
using aspboard.mvc6.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace aspboard.mvc6.Controllers
{
    public class AccountController : Controller
    {
        // GET: /<controller>/
        /// <summary>
        /// login page
        /// </summary>
        /// <returns></returns>
        /// 
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        /// <summary>
        /// register page
        /// </summary>
        /// <returns></returns>
        
        // default get method
        // display register page 
        public IActionResult Register()
        {
            return View();
        }

        // register submit post method
        // receive form data
        [HttpPost]
        public IActionResult Register(User model)
        {
            if(ModelState.IsValid)
            {
                using (var db = new BoardDbContext())
                {
                    db.Users.Add(model);
                    db.SaveChanges();
                }
                return RedirectToAction("Index", "Home");
            }
            return View(model);
        }
    }
}
