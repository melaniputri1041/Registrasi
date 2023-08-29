using Microsoft.AspNetCore.Mvc;
using Registrasi.Data;
using Registrasi.Models;
using System.Collections.Generic;

namespace Registrasi.Controllers
{
    public class EducationController : Controller
    {
        private readonly MySqlContext _context;

        public object DbTest { get; private set; }

        public EducationController(MySqlContext c)
        {
            _context = c;
        }
        public IActionResult Index()
        {

            return View();
        }
        public IActionResult Create()
        {

            return View();
        }

        [HttpPost]
        public IActionResult Create([FromForm] Education data)
        {
            _context.Education.Add(data);
            _context.SaveChanges();
            return RedirectToAction("Index", "Registrasi");
        }
    }
}
