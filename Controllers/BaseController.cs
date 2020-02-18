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
        private ILogger<BaseController> _logger;

        public ILogger<BaseController> Logger { get => _logger; set => _logger = value; }

        public BaseController(ILogger<HomeController> logger)
        {
            Logger = logger;
        }

        public BaseController()
        {

        }
    }
}