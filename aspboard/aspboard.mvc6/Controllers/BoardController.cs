using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using aspboard.mvc6.DataContext;
using aspboard.mvc6.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace aspboard.mvc6.Controllers
{
    public class BoardController : Controller
    {
        /// <summary>
        /// board list
        /// </summary>
        /// <returns></returns>
        /// 
        // GET: /<controller>/
        public IActionResult Index()
        {
            //login 했는지 안 했는지 확인
            if(HttpContext.Session.GetInt32("UserKey") == null)
            {
                // login 안된 상태
                return RedirectToAction("Login", "Account");
            }
            
            using (var db = new BoardDbContext())
            {
                var list = db.Boards.ToList();
                return View(list);
            }
            
        }

        public IActionResult Detail(int boardNo)
        {
            if (HttpContext.Session.GetInt32("UserKey") == null)
            {
                // login 안된 상태
                return RedirectToAction("Login", "Account");
            }

            using (var db = new BoardDbContext())
            {
                var note = db.Boards.FirstOrDefault(b => b.BoardNo.Equals(boardNo));
                return View(note);
            }
        }

        public IActionResult Add()
        {
            if (HttpContext.Session.GetInt32("UserKey") == null)
            {
                // login 안된 상태
                return RedirectToAction("Login", "Account");
            }

            return View();
        }
        
        [HttpPost]
        public IActionResult Add(Board model)
        {
            if (HttpContext.Session.GetInt32("UserKey") == null)
            {
                // login 안된 상태
                return RedirectToAction("Login", "Account");
            }
            model.UserNo = int.Parse(HttpContext.Session.GetInt32("UserKey").ToString());

            if (ModelState.IsValid)
            {
                using (var db = new BoardDbContext())
                {
                    db.Boards.Add(model);
                    //sacechanges는 성공한 개수 반환

                    if(db.SaveChanges() > 0)
                    {
                        return Redirect("Index");
                    }
                    //동일한 컨트롤러 안에서의 redirect는 redirecttoaction 말고 redirect
                }
                ModelState.AddModelError(string.Empty, "can't save the document");
            }
            return View(model);
        }
        public IActionResult Edit()
        {
            if (HttpContext.Session.GetInt32("UserKey") == null)
            {
                // login 안된 상태
                return RedirectToAction("Login", "Account");
            }

            return View();
        }

        public IActionResult Delete()
        {
            if (HttpContext.Session.GetInt32("UserKey") == null)
            {
                // login 안된 상태
                return RedirectToAction("Login", "Account");
            }

            return View();
        }
    }
}
