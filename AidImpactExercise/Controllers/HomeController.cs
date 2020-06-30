using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using AidImpactExercise.Models;

namespace AidImpactExercise.Controllers
{
    public class HomeController : Controller
    {
        private readonly PointDataContext _db;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, PointDataContext _db)
        {
            this._logger = logger;
            this._db = _db;
        }

        public IActionResult Index()
        {
            var points = _db.Points.Take(5).ToArray();
            return View(points);
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
