using Microsoft.EntityFrameworkCore;
using Study_Site.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Study_Site.Persistence.Contexts
{
    public class StudySiteDbContext : DbContext
    {
        public StudySiteDbContext(DbContextOptions options) : base(options)
        { }
        public DbSet<Town> Towns { get; set; }
        public DbSet<ClockTower> ClockTower { get; set; }
    }
}
