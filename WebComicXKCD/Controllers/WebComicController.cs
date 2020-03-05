using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebComicXKCD.BLL;
using WebComicXKCD.ViewModels;

namespace WebComicXKCD.Controllers
{
    public class WebComicController : Controller
    {

        public IWebComic _webComic;

        public WebComicController(IWebComic webComicA)
        {
            _webComic = webComicA;
        }

        [HttpGet("comic/{id}")]
        public IActionResult Index(int id)
        {

            Task<ComicVM> res;
            res = _webComic.PreviousPage(id);
            return View(res);
        }
    }
}