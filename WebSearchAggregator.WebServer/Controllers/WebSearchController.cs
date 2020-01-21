using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebSearchAggregator.Controllers
{
    public class WebSearchController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}