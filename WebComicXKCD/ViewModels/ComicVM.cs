using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebComicXKCD.ViewModels
{
    public class ComicVM
    {
        public string alt { get; set; }
        public string img { get; set; }
        public int num { get; set; }

        public string title { get; set; }

        public int NextPage { get; set; }

        public int PrevPage { get; set; }

        public int maxComic { get; set; }
    }
}
