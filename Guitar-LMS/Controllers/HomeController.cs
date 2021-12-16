using System;
using Microsoft.AspNetCore.Mvc;

namespace Guitar_LMS.Controllers {
    [Route("[controller]/[action]")]
    public class HomeController : Controller{
        public HomeController() {
        }

        [Route("~/")]
        [Route("")]
        public IActionResult Index() {
            return View();
        }

        [Route("{dateStr}")]
        public IActionResult ToDoList(string dateStr) {
            return View();
        }
    }
}
