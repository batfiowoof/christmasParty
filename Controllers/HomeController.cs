using christmasParty.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace christmasParty.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _db;

        public HomeController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult RsvpForm()
        {
            return View();
        }
        [HttpPost]
        public IActionResult RsvpForm(Invitation obj)
        {
            if (ModelState.IsValid)
            {
                _db.Responses.Add(obj);
                _db.SaveChanges();
            }
            return View(obj);
        }
        public IActionResult ListResponses()
        {
            IEnumerable<Invitation> obj = _db.Responses.Where(r => r.isAttending == true);
            return View(obj);
        }
    }
}
