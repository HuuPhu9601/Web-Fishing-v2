using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebLQ.Models;

namespace WebLQ.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            Accounts acc = new Accounts();
            return View(acc);
        }

        [HttpPost]
        public IActionResult GetAccount(Accounts acc)
        {

            return Ok();
        }
    }
}
