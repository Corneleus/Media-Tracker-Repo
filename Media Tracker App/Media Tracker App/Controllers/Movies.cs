using System.Web.Mvc;

namespace Media_Tracker_App.Controllers
{
    public class Movies : Controller
    {
        // GET: movies
        public ActionResult Index()
        {
            return View();
        }
    }
}