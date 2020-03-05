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

            using (var httpclient = new HttpClient())
            {

                using (var response = httpclient.GetAsync("https://xkcd.com/info.0.json"))
                {
                    string jsonResponse = await response.Result.Content.ReadAsStringAsync();
                    WebComic = JsonConvert.DeserializeObject<ComicVM>(jsonResponse);

                    WebComic.PrevPage = WebComic.num - 1;
                    WebComic.maxComic = WebComic.num;


                }

            }

            return WebComic;

        }



        public async Task<ComicVM> PreviousPage(int NumPage)
        {

            NumPage = NumPage == 404 ? NumPage + 2 : NumPage;
            ComicVM WebComic = new ComicVM();
            ComicVM WebComicActual = new ComicVM();
            using (var httpClient = new HttpClient())
            {
                using (var response = httpClient.GetAsync($"https://xkcd.com/{NumPage}/info.0.json"))
                {


                    //para sacar dato de maximo numero solo
                    var maximo = httpClient.GetAsync("https://xkcd.com/info.0.json");
                    string jsonResponseMax = await maximo.Result.Content.ReadAsStringAsync();
                    WebComicActual = JsonConvert.DeserializeObject<ComicVM>(jsonResponseMax);



                    string json = await response.Result.Content.ReadAsStringAsync();
                    WebComic = JsonConvert.DeserializeObject<ComicVM>(json);



                    WebComic.maxComic = WebComicActual.num;
                    WebComic.PrevPage = WebComic.num == 405 ? WebComic.num - 2 : WebComic.num - 1;
                    WebComic.NextPage = WebComic.num == 403 ? WebComic.num + 2 : WebComic.num + 1;


                }
            }

            return WebComic;
        }

    }
}
