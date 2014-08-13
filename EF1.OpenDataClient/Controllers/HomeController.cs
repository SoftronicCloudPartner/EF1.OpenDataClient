using System.Configuration;
using System.Web.Mvc;

namespace EF1.OpenDataClient.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Invoice()
        {
            ViewBag.DataSourceUri = ConfigurationManager.AppSettings["DataSourceUriInvoice"];
            return View();
        }

        public ActionResult Diary()
        {
            ViewBag.DataSourceUri = ConfigurationManager.AppSettings["DataSourceUriDiary"];
            return View();
        }

        public ActionResult Api()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

    }
}