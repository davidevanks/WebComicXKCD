using NUnit.Framework;
using WebComicXKCD.BLL;
using WebComicXKCD.ViewModels;
namespace WebComicTest
{
    public class Tests
    {


        WebComic _WebComic;

        public Tests()
        {
            _WebComic = new WebComic();
        }


        [Test]
        public void WebComicActual()
        {

            var res = _WebComic.ActualComic();

            Assert.Pass();
            Assert.NotNull(res.Result);

        }


        [Test]
        public void WebComicPrevious()
        {

            var res = _WebComic.PreviousPage(400);

            Assert.NotNull(res.Result);
            Assert.Pass();

        }

        /*Comprobamos si al buscar el comic 404 da error*/
        [Test]
        public void WebComicPrevious404()
        {

            var res = _WebComic.PreviousPage(404);

            Assert.NotNull(res.Result);
            Assert.Pass();

        }
    }
}