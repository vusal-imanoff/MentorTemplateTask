using AutoMapper.Features;
using MentorTemplate.DAL;
using MentorTemplate.Models;
using MentorTemplate.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MentorTemplate.Controllers
{
    
    public class PricingController : Controller
    {
        public readonly AppDbContext _context;
        public PricingController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            PricingsVM pricingsVM = new PricingsVM
            {
                Pricings = _context.Pricings.Include(x => x.JoinPricingFeatures).ThenInclude(x => x.Features).ToList(),
                Features = _context.Features.Include(x=> x.JoinPricingFeatures).ThenInclude(x=>x.Pricings).ToList()

            };
            return View(pricingsVM);
        }
    }
}
