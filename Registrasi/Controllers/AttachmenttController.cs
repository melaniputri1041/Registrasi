using Microsoft.AspNetCore.Mvc;
using Registrasi.Data;
using Registrasi.Models;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;

namespace Registrasi.Controllers
{
    public class AttachmenttController : Controller
    {
        private readonly MySqlContext _context;

        public object DbTest { get; private set; }

        public AttachmenttController(MySqlContext c)
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
        public IActionResult Create([FromForm] Attachmentt data)
        {
            _context.Attachmentt.Add(data);
            _context.SaveChanges();
            return RedirectToAction("Create", "Education");
        }
    }
}
