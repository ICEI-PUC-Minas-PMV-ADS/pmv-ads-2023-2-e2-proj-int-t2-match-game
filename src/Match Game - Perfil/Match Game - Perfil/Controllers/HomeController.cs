using Match_Game___Perfil.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Match_Game___Perfil.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            UserName home = new UserName();

            home.Name = "Joaquim da Silva";

            return View(home);
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