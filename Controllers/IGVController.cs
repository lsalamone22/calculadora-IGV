using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using webapp.Models;

namespace webapp.Controllers
{
    
    public class IGVController : Controller
    {
        private readonly ILogger<IGVController> _logger;

        public IGVController(ILogger<IGVController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Calcular(IGV objIGV)
        {

                double resultado = 0.0;
                double total = 0.0;
                resultado = objIGV.Pre * 0.18;
                total = resultado + objIGV.Pre;

                ViewData["Message"] ="El IGV es " + resultado + " y el Total es " + total;


            return View("Index");
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}