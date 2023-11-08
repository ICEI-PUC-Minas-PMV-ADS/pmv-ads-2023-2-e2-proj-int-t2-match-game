using Microsoft.AspNetCore.Mvc;

namespace Match_Game_Oficial.Controllers
{
    public class Favoritos : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
