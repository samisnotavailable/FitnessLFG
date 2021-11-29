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
    public class CrudController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CrudController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var list = _context.Cruds.ToList();
            return View(list);
        }
        
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Crud record)
        {
            var crud = new Crud()
            {
                Type = record.Type,
                ActivityCategory = record.ActivityCategory,
                FullName = record.FullName,
                MobileNumber = record.MobileNumber,
                Schedule = record.Schedule,
                MeetingPlace = record.MeetingPlace,
                MaxNumberPeople = record.MaxNumberPeople
            };
            _context.Cruds.Add(crud);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }

        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }

            var item = _context.Cruds.Where(i => i.CrudId == id).SingleOrDefault();
            if (item == null)
            {
                return RedirectToAction("Index");
            }

            return View(item);
        }

        [HttpPost]
        public IActionResult Edit(int? id, Crud record)
        {
            var item = _context.Cruds.Where(i => i.CrudId == id).SingleOrDefault();
            item.Type = record.Type;
            item.ActivityCategory = record.ActivityCategory;
            item.FullName = record.FullName;
            item.MobileNumber = record.MobileNumber;
            item.Schedule = record.Schedule;
            item.MeetingPlace = record.MeetingPlace;
            item.MaxNumberPeople = record.MaxNumberPeople;

            _context.Cruds.Update(item);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }

        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }
            var item = _context.Cruds.Where(i => i.CrudId == id).SingleOrDefault();
            if (item == null)
            {
                return RedirectToAction("Index");
            }

            _context.Cruds.Remove(item);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }


    }
}

