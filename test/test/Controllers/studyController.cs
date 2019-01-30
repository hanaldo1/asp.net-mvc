using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using test.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace test.Controllers
{
    public class studyController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            // 5. 강의 내용
            //var firstUser = new User();
            //firstUser.UserNo = 1;
            //firstUser.UserName = "가나다";

            var firstUser = new User
            {
                UserNo = 1,
                UserName = "가나다"
            };

            // 1번째 방법 : 인자값으로 
            //return View(firstUser);

            // 2번째 방법 : ViewBag
            //ViewBag.User = firstUser;
            //return View();

            // 3번째 방법 : ViewData
            ViewData["UserNo"] = firstUser.UserNo;
            ViewData["UserName"] = firstUser.UserName;

            return View();
        }
        public IActionResult Error()
        {
            return View();
        }
    }
}
