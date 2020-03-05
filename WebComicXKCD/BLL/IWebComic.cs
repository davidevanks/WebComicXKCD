using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebComicXKCD.ViewModels;
namespace WebComicXKCD.BLL
{
   public interface IWebComic
    {
        public Task<ComicVM> ActualComic();
    }
}
