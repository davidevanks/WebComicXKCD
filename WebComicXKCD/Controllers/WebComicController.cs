using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebComicXKCD.BLL;

namespace WebComicXKCD.Controllers
{
    public class WebComicController : Controller
    {

        public IWebComic _webComic;

        public WebComicController(IWebComic webComicA)
        {
            _webComic = webComicA;
        }

        [HttpGet("Comic/{id}")]
        public IActionResult Index(int id)
        {
           
            return View();
        }
    }
}