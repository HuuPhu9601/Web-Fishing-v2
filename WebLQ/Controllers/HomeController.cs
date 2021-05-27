using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebLQ.Models;
namespace WebLQ.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            List<BinhLuan> binhLuans = new List<BinhLuan>();
            foreach (var item in binhLuans)
            {
                ViewBag.Conment = item.Name + " " + item.Value;
                break;
            }

            return View();
        }
        [HttpPost]
        public IActionResult Index(int a)
        {
            var t = Response.Cookies;

            return Ok();
        }

        public IActionResult MyanmaIndex()
        {
            return View();
        }

        public IActionResult ThaiLangueIndex()
        {
            return View();
        }
        public IActionResult PhilipLangueIndex()
        {
            return View();
        }
    }
}
