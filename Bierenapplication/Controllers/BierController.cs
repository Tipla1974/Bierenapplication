using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bierenapplication.Models;
using Microsoft.AspNetCore.Mvc;

namespace Bierenapplication.Controllers
{
    public class BierController : Controller
    {
        public IActionResult Index()
        {
            var bieren = new List<Bier>();
            bieren.Add(new Bier {
                ID = 22,
                Naam = "Kruger",
                Alcohol = 4.8F
            }) ;
            bieren.Add(new Bier
            {
                ID = 23,
                Naam = "Duvel",
                Alcohol = 8F
            });
            bieren.Add(new Bier
            {
                ID = 40,
                Naam = "Jupiler",
                Alcohol = 5.2F
            });
            bieren.Add(new Bier
            {
                ID = 41,
                Naam = "Kasteelbier",
                Alcohol = 11F
            });
            return View(bieren);
        }
    }
}
