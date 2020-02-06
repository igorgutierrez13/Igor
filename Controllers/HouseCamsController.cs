using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Igor.Controllers
{
    public class HouseCamsController : Controller
    {
        [Authorize]
        public IActionResult HouseCamsIndex()
        {
            return View();
        }
    }
}