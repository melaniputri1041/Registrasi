using Microsoft.AspNetCore.Mvc;
using Registrasi.Data;
using Registrasi.Models;
using System.Collections.Generic;
using System.Linq;

namespace Registrasi.Controllers
{
	public class WorkExperienceController : Controller
	{
		private readonly MySqlContext _context;

		public object DbTest { get; private set; }

		public WorkExperienceController(MySqlContext c)
		{
			_context = c;
		}
		public IActionResult Index()
		{

			List<WorkExperience> agenss = _context.WorkExperience.ToList();
			return View(agenss);
		}
		public IActionResult Create(int agenId)
		{
            ViewBag.AgenId = agenId;
            return View();
		}

		[HttpPost]
		public IActionResult Create([FromForm] WorkExperience data)
		{
            _context.WorkExperience.Add(data);
			_context.SaveChanges();
			return RedirectToAction("Create", "Attachmentt");
		}
	}
}
