using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Sbidu.Data;
using Sbidu.Models;
using Sbidu.ViewModels;

namespace Sbidu.Controllers
{
    public class ContactController : Controller
    {
        private readonly ApplicationDbContext _context;
        public ContactController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        [Route("contact")]
        public IActionResult Index()
        {
            ContactViewModel contact = new ContactViewModel
            {
                Contact = _context.Contacts.FirstOrDefault()
            };
            return View(contact);
        }

        [HttpPost]
        [Route("contact")]
        public IActionResult Send(ContactViewModel model)
        {
            if (ModelState.IsValid)
            {
                Message message = new Message
                {
                    Name = model.Message.Name,
                    Email = model.Message.Email,
                    Text = model.Message.Text
                };

                _context.Messages.Add(message);
                _context.SaveChanges();

                return RedirectToAction("index", "thanks");
            }

            return NoContent();
        }
    }
}
