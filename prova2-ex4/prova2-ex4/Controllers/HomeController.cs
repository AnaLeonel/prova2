using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using prova2_ex4.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace prova2_ex4.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
