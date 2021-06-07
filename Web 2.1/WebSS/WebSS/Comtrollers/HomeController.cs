using Microsoft.AspNetCore.Mvc;
using System;
using WebSS.Models;
using WebSS.Services;

namespace WebSS.Comtrollers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult PassUsingModel()
        {
            PassUsingModel pass = new PassUsingModel();
            return View(pass);
        }
        public IActionResult PassUsingViewData()
        {
            @ViewData["Rand"] = new Pass();
            return View();
        }

        public IActionResult PassUsingViewBag()
        {
            ViewBag.Rand = new Pass();
            return View();
        }

        public IActionResult PassUsingServiceInjection()
        {
            return View();
        }
    }
    
}
