using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using WebComicXKCD.ViewModels;
using Newtonsoft.Json;
namespace WebComicXKCD.BLL
{
    public class WebComic : IWebComic
    {

        public async Task<ComicVM> ActualComic()
        {
            ComicVM WebComic = new ComicVM();

            using(var httpclient=new HttpClient())
            {

                using (var response= httpclient.GetAsync("https://xkcd.com/info.0.json"))
                {
                    string jsonResponse = await response.Result.Content.ReadAsStringAsync();
                    WebComic = JsonConvert.DeserializeObject<ComicVM>(jsonResponse);

                }

            }

            return WebComic;
                
        }

    }
}
