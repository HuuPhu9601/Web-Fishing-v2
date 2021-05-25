using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebLQ.Models;
using WebLQ.Service;
namespace WebLQ.Controllers
{
    public class HomeController : Controller
    {
        AutoChatService auto = new AutoChatService();
        public IActionResult Index()
        {
            List<BinhLuan> binhLuans = new List<BinhLuan>();
            auto.ReadFile(binhLuans);
            foreach (var item in binhLuans)
            {
                ViewBag.Conment = item.Name + " " + item.Value;
                break;
            }
            return View();
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
