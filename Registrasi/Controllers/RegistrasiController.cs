using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using Registrasi.Data;
using Registrasi.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Registrasi.Controllers
{
	public class RegistrasiController : Controller
	{
        private readonly MySqlContext _context;

        public object DbTest { get; private set; }

        public RegistrasiController(MySqlContext c)
        {
            _context = c;
        }
        public IActionResult Index()
        {

			List<Agen> agenss = _context.Agen.ToList(); 
            return View(agenss);
		}
        public IActionResult Create()
        {
                                          
            return View();
        }

        [HttpPost]
        public IActionResult Create([FromForm] Agen data)
        { 
            _context.Agen.Add(data);
            _context.SaveChanges();
            return RedirectToAction("Create", "WorkExperience");
        }

		public IActionResult Detail(int id)
		{
            var kombinasii = new Kombinasi
            {
                Agen = _context.Agen.Where(a => a.AgenId == id).ToList(),
                WorkExperience = _context.WorkExperience.Where(a => a.WorkExperienceId == id).ToList(),
                Attachmentt = _context.Attachmentt.Where(a => a.AttachmentId == id).ToList(),
                Education = _context.Education.Where(a => a.EducationId == id).ToList(),
            };

            return View(kombinasii);
		}
	}
}
