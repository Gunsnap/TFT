using System;
using System.Web.Mvc;

namespace TFT_Main.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            // Finder den kørende MVC.
            var mvcName = typeof(Controller).Assembly.GetName();

            // Hvis resultatet er null findes Mono ikke og resultatet bliver false.
            var isMono = Type.GetType("Mono.Runtime") != null;

            // Viser den fulde version af den MVC der bliver brugt.
            ViewData["Version"] = mvcName.Version.ToString();

            // Viser hvilket runtime vi kører på; Hvis det ikke er Mono (UNIX) må det jo være .NET (Windows).
            ViewData["Runtime"] = isMono ? "Mono" : ".NET";

            return View();
        }
    }
}