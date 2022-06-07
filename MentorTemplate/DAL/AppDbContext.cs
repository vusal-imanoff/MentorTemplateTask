using MentorTemplate.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MentorTemplate.DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        { }

        public DbSet<Trainers> Trainers { get; set; }
        public DbSet<Positions> Positions { get; set; }

        public DbSet<Events> Events { get; set; }
        public DbSet<Coursers> Coursers { get; set; }
        public DbSet<Features> Features { get; set; }
        public DbSet<Pricings> Pricings { get; set; }
        public DbSet<JoinPricingFeatures> JoinPricingFeatures { get; set; }





    }
}
