﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using InstaDev_G1_DT.Models;

namespace InstaDev_G1_DT.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            Publication publicationModel=new Publication();
            ViewBag.Publication = publicationModel.ReadAllItens();
           
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
    }
}
