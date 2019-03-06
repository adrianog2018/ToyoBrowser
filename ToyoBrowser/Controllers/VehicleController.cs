using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ToyoBrowser.Models;
using ToyoBrowser.Models.Dto;


namespace ToyoBrowser.Controllers
{
    public class VehicleController : Controller
    {
        private readonly ToyoContext _context;

        public VehicleController(ToyoContext context)
        {
            _context = context;
        }
        // GET
        public IActionResult Index()
        {
            var cars = _context.Vehicles
                .Include(v => v.VehicleClass)
                .Include(vc => vc.Model)
                .ThenInclude(m => m.TrimsLevels)
                .Where(v => v.VehicleClass.Name == "Cars and Minivan")
                .ToList();



            return View(cars);
        }

        public IActionResult Class(string id)
        {

            var vehicleClass = id;

            switch (id)
            {
                case "Cars":
                    vehicleClass = "Cars and Minivan";
                    break;
                case "Suvs":
                    vehicleClass = "Crossovers & SUVs";
                    break;
                case "Hybrids":
                    vehicleClass = "Hybrids & Fuel Cell";
                    break;
            }
            

            var model = _context.Vehicles
                .Where(v => v.VehicleClass.Name == vehicleClass)
                .Include(v => v.VehicleClass)
                .Include(v => v.Model)
                .ToList();

            return View("Cars", model);

        }

        public IActionResult TrimsLevel(int id)
        {
            //var picture = _context.TrimsLevels.FirstOrDefault(v => v.ModelId == id)?.TrimPicture;

            var model = _context.TrimsLevels
                .Where(t => t.ModelId == id)
                .Include(t => t.Model)
                .ToList();

            //var res = new TrimsLevel
            //{
            //    TrimPicture = picture,s
                
            //};

            return View(model);

        }

    public IActionResult Features(int id)
        {
            var model = _context.TrimsLevel_Features
                .Where(tl => tl.TrimsLevelId == id)
                .Include(tf => tf.TrimsLevel)
                .ThenInclude(t => t.Model)
                .Include(tf => tf.Features)
                .ToList();

            return View(model);
        }

        [HttpPost]
        public IActionResult Search(string search)
        {
            //var search = "Yaris"; for testing purpose
            var models = _context.Models.Where(m => m.Name.Contains(search, StringComparison.InvariantCultureIgnoreCase)).Select(m => m.Id).ToList();

            var cars = _context.Vehicles
                .Where(v => models.Contains(v.ModelId))
                .Include(v => v.VehicleClass)
                .Include(v => v.Model)
                .ToList();

            return View("Cars", cars);
        }
    }
}