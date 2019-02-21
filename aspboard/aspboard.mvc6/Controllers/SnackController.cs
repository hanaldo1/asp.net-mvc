using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using aspboard.mvc6.DataContext;
using aspboard.mvc6.Models;
using aspboard.mvc6.ViewModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace aspboard.mvc6.Controllers
{
    public class SnackController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            //if (HttpContext.Session.GetInt32("UserKey") == null)
            //{
            //    // login 안된 상태
            //    return RedirectToAction("Login", "Account");
            //}

            using (var db = new BoardDbContext())
            {
                var snack = db.Snacks.ToList();
                return View(snack);
            }

        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(string Sname, int Sprice)
        {
            int SnackVote = 0;
            var model = new Snack();
            model.SnackName = Sname;
            model.SnackPrice = Sprice;

                using (var db = new BoardDbContext())
                {
                    db.Snacks.Add(model);
                    if (db.SaveChanges() > 0)
                    {
                        return Redirect("Index");
                    }
                }
            return View(model);
        }
    }
}
