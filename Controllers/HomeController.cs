using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Log4NetProject.Models;

namespace Log4NetProject.Controllers
{
    public class HomeController : Controller
    {
        private log4net.ILog log = log4net.LogManager.GetLogger(Startup.repository.Name, typeof(HomeController));
        public IActionResult Index()
        {
            log.Warn("this is in HomeController's index action!");
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
