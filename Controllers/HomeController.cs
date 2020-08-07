using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DojoSurveyWithModel.Models;

namespace DojoSurveyWithModel.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        [HttpGet("survey")]
        public IActionResult Result(string Name,string Locations, string Languages, string Comments)

        {
            ViewBag.Name = Name;
            ViewBag.Locations = Locations;
            ViewBag.Languages= Languages;
            ViewBag.Comments = Comments;
            return View("Survey");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
