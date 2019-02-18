using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using aspboard.mvc6.DataContext;
using aspboard.mvc6.Models;
using aspboard.mvc6.ViewModel;
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
        
        [HttpPost]
        public IActionResult Login(LoginVm model)
        {
            // id, password 필수 입력 값
            if(ModelState.IsValid)
            {
                using (var db = new BoardDbContext()) // open db connection
                {
                    // linq query 메서드 체이닝
                    // => : a go to b
                    // u 익명인수
                    // db에 있는 id와 model의 id가 같으면 user가 나옴(pw도)
                    // 비교할 때 == 사용보다 Equals 사용
                    var user = db.Users.FirstOrDefault(
                        u=>u.UserId.Equals(model.UserId) && u.UserPw.Equals(model.UserPw)); // user table 중 첫번째 

                    if (user != null)
                    {
                        // login success
                        return RedirectToAction("LoginSuccess", "Home");
                    }
                }
                // login fail
                // 굳이 using 문 안에 넣지 않아도 되는 코드 
                ModelState.AddModelError(string.Empty, "사용자 id 혹은 password가 올바르지 않습니다.");
            }
            return View(model);
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
