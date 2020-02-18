using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Igor.Controllers
{
    public class HouseCamsController : BaseController
    {
        [Authorize]
        public IActionResult Index()
        {
            return View();
        }
    }
}