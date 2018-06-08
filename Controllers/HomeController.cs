using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using viewModel_Fun.Models;

namespace viewModel_Fun.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            string important = "hsbksf";
            return View("Index", important);
        }

        [Route("numbers")]
        public IActionResult numbers()
        {
            int[] arr = {1,3,5,7,9};
            return View("Numbers", arr);
        }
        [Route("users")]
        public IActionResult users()
        {
            List<User> userlist = new List<User>();
            User boi = new User(){fname = "jimmy", lname = "johns"};
            User guy = new User(){fname = "hello"};
            User cplanet = new User(){fname = "captain", lname = "planet"};
            userlist.Add(boi);
            userlist.Add(guy);
            userlist.Add(cplanet);
            return View("Users", userlist);
        }
        [Route("user")]
        public IActionResult user()
        {
            User friend = new User(){fname = "bes", lname = "fweeend"};
            return View("User", friend);
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
