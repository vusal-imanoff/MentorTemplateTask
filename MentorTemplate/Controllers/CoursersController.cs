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
    public class CoursersController : Controller
    {
        public readonly AppDbContext _context;
        public CoursersController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<Coursers> coursers = _context.Coursers.Include(x=>x.Position).ToList();
            return View(coursers);
        }

        public IActionResult Detail(int? id)
        {
            return View();
        }
    }
}
