﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AidImpactExercise.Models;
using Microsoft.AspNetCore.Mvc;

namespace AidImpactExercise.Controllers
{
    [Route("point")]
    public class PointController : Controller
    {
        private readonly PointDataContext _db;

        public PointController(PointDataContext _db)
        {
            this._db = _db;
        }

        [HttpGet, Route("create")]
        public IActionResult Create()
        {
            return View();
        }

        public IActionResult Post(Point point)
        {
            return View(point);
        }

        [HttpPost, Route("create")]
        public IActionResult Create(Point point)
        {
            // If isn't valid get back to basic view
            if (!ModelState.IsValid)
                return View();

            _db.Points.Add(point);
            _db.SaveChanges();

            return RedirectToAction("Post", "Point", point);
        }
    }
}
