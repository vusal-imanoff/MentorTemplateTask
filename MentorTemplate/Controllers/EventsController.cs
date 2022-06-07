using MentorTemplate.DAL;
using MentorTemplate.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MentorTemplate.Controllers
{
    public class EventsController : Controller
    {
        public readonly AppDbContext _context;
        public EventsController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<Events> events = _context.Events.ToList();
            return View(events);
        }
    }
}
