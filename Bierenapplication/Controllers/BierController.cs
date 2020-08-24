using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bierenapplication.Models;
using Microsoft.AspNetCore.Mvc;
using Bierenapplication.Services;

using Newtonsoft.Json;

namespace Bierenapplication.Controllers
{
    public class BierController : Controller
    {
        private BierService _bierService;
        public BierController(BierService bierService)
        {
            _bierService = bierService;
        }
        public IActionResult Index()
        {
            var bieren = _bierService.Findall();
            return View(bieren);
        }
        public IActionResult Bieren()
        {
            return View(_bierService.Findall());
        }
        public IActionResult Verwijderen(int id)
        {
            var bier = _bierService.Read(id);
            return View(bier);
        }
        [HttpPost]
        public IActionResult Delete(int id)
        {
            var bier = _bierService.Read(id);
            this.TempData["bier"] = JsonConvert.SerializeObject(bier);
            _bierService.delete(id);
            return Redirect("~/Bier/Verwijderd");
        }
        public IActionResult Verwijderd()
        {
            var bier = JsonConvert.DeserializeObject<Bier>(
                (string)this.TempData["bier"]);
            return View(bier);
        }
        public IActionResult Toevoegen()
        {
            var bier = new Bier();
            return View(bier);
        }
        [HttpPost]
        public IActionResult Toevoegen(Bier p) 
        { 
            if (this.ModelState.IsValid) 
            { 
                _bierService.Add(p); 
                return RedirectToAction("Index"); 
            } 
            else return View(p); 
        }
    }
}
