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
    public class TrainersController : Controller
    {
        public readonly AppDbContext _context;

        public TrainersController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<Trainers> trainers = _context.Trainers.Include(x=>x.Position).ToList();
            return View(trainers);
        }
    }
}
