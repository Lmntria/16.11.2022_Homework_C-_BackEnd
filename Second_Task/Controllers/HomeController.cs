using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Second_Task.Models;
using Second_Task.ViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Second_Task.Controllers
{
    public class HomeController : Controller
    {
        
        public IActionResult Index()
        {
            List<Features> features = Data.Features;
            List<Service> services = Data.Services;

            HomeVM hmv = new HomeVM
            {
                Feature = features,
                Service = services
            };

            return View(hmv);
        }
    }
}

