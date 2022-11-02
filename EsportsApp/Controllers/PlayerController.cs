using EsportsApp.Db;
using EsportsApp.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EsportsApp.Controllers
{
    public class PlayerController : Controller
    {
        private AppDbContext _context { get; set; }
        public PlayerController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var data = _context.PlayerData.ToList();
            return View(data);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(PlayerModel data)
        {
            _context.PlayerData.Add(data);
            var result = _context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }

        public IActionResult Update(int ID)
        {
            var data = _context.PlayerData.Find(ID);
            return View(data);

        }

        [HttpPost]
        public IActionResult Update(PlayerModel data)
        {
            _context.PlayerData.Update(data);
            var result = _context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }
        
        public IActionResult Delete(int ID)
        {
            var data = _context.PlayerData.Find(ID);
            _context.PlayerData.Remove(data);
            var result = _context.SaveChanges();

            return RedirectToAction(nameof(Index));

        }


    }

    
}
