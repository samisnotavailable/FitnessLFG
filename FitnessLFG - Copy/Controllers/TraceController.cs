using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;
using Microsoft.AspNetCore.Mvc;
using FitnessLFG.Data;
using FitnessLFG.Models;

namespace FitnessLFG.Controllers
{
    public class TraceController : Controller
    {
        private readonly ApplicationDbContext _context;

        public TraceController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var list = _context.Traces.ToList();
            return View(list);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(ContactTrace record)
        {
            var trace = new ContactTrace
            {
                FullName = record.FullName,
                ContactNum = record.ContactNum,
                Email = record.Email,
                VaccineCenter = record.VaccineCenter,
                Doses = record.Doses,
                SickContact = record.SickContact,
                Symptoms = record.Symptoms
            };

            _context.Traces.Add(trace);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}