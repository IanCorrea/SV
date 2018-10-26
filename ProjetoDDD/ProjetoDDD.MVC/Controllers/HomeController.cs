using System.Web.Mvc;

namespace ProjetoDDD.MVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.PanelType = "panel-home";
            ViewBag.PanelTitle = "Home";
            return View();
        }
    }
}