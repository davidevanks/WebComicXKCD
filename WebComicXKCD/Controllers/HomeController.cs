using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebComicXKCD.Models;
using WebComicXKCD.BLL;
using WebComicXKCD.ViewModels;

namespace WebComicXKCD.Controllers
{
    public class HomeController : Controller
    {


        public IWebComic _webComic;

        public HomeController(IWebComic webComicA)
        {
            _webComic = webComicA;
        }

   

        public IActionResult Index()
        {
            Task<ComicVM> res ;
             res = _webComic.ActualComic();
            return View(res);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
