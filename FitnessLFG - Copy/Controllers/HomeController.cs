using FitnessLFG.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

using System.Net;
using System.Net.Mail;

namespace FitnessLFG.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult ContactUs()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ContactUs(ContactUs record)
        {
            MailMessage mail = new MailMessage()
            {
                From = new MailAddress("samuelnoel67@gmail.com", "The Administrator")
            };
            mail.To.Add(new MailAddress(record.Email));

            mail.Subject = "Inquiry from " + record.Sender + " (" + record.Subject + ")";
            string message = "Hello, " + record.Sender + "<br/><br/>" +
                "We have received your inquiry. Here are the details: <br/><br/>" +
                "Contact Number: <strong>" + record.ContactNo + " </strong><br/>" +
                "Message:<br><strong>" + record.Message + "</strong><br/><br/>" +
                "Please wait for our reply. Our team will get back to you as soon as possible. Thank you, and I love you !";
            
            mail.Body = message;
            mail.IsBodyHtml = true;

            using SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587)
            {
                Credentials = new NetworkCredential("samuelnoel67@gmail.com", "Ramb0tt0m$"),
                EnableSsl = true
            };
            smtp.Send(mail);
            ViewBag.Message = "Inquiry sent.";
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
