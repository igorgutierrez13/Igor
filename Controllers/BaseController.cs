using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Igor.Controllers
{
    public class BaseController : Controller
    {
        public ILogger<BaseController> _logger;
        public BaseController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public BaseController()
        {

        }
    }
}